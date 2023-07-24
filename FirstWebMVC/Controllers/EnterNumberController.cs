
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;

public class EnterNumberController : Controller
{
    public IActionResult Index ()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (int Number)
    {
        int binhphuong = Number * Number ;
        ViewBag.Message = "Binh phuong cua mot so " + Number + "la :" + binhphuong;
        return View();

    }
   
}
