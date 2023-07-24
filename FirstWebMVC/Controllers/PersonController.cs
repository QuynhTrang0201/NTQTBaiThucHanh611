
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;

public class PersonController : Controller
{
    public IActionResult Index ()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (Person ps)
    {
        string message = ps.FullName + "-" + ps.ID +"-" + ps.Address;
        ViewBag.thongBao = message;
        return View();

    }
   
}