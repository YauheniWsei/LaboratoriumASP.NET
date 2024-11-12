using LaboratoriumASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoriumASP.NET.Controllers;

public class KomputerController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Komputer komputer)
    {
        if(ModelState.IsValid)
        {
            //код когда данные правельные 
            return RedirectToAction("Index", "Home");
        }
        else
        {
            return View();
        }
    }
}