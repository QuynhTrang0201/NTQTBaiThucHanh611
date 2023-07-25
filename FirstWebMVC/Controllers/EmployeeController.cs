using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mime;
using FirstWebMVC.Data;
using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models.Process;

namespace FirstWebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ExcelProcess _excelProcess = new ExcelProcess();
        public EmployeeController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.Employees.ToListAsync());
        }
        public IActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create( Employee emp)
        {
            if(ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emp);
        }

//Employee/Upload
        public async Task<IActionResult> Upload()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file!=null)
            {
                 string fileExtension = Path.GetExtension(file.FileName);
            if (fileExtension != ".xls" && fileExtension != ".xlsl")
            {
                 //rename file when upload to server 
                var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
                var filePath= Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName);
                var fileLocation = new FileInfo(filePath).ToString();
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    //save file to sever
                    await file.CopyToAsync(stream);
                    //read data from file and write to database 
                    var dt = _excelProcess.ExcelToDataTable(fileLocation);
                        for (int i =0; i < dt.Rows.Count; i++)
                        {
                        var emp = new Employee();
                        emp.EmpID = dt.Rows[i][0].ToString();
                        emp.EmpName = dt.Rows[i][1].ToString();
                        emp.Address= dt.Rows[i][2].ToString();
                        _context.Employees.Add(emp);
                        }
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                        

                    }      
            }
            else
                {
                    ModelState.AddModelError("", "Please choose excel file to upload!");
                }
            }
            return View();
        }
        private bool EmployeeExists(string id)
        {
            return _context.Employees.Any(e =>e.EmpID == id);
        }
    }
}
