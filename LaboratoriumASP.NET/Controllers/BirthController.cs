using LaboratoriumASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoriumASP.NET.Controllers;

public class BirthController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Birth()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult BirthResult([FromForm] Birth model)
    {
        if (!model.isValid())
        {
            ViewBag.Komunikat = "Nieprawidlowe dane";
            return View(model);
        }
        
        ViewBag.Komunikat = "Wynik działania: ";
        return View(model);
    }
}