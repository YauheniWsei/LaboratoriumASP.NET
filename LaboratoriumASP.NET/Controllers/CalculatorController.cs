using LaboratoriumASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoriumASP.NET.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Form()
    {
        return View();
    }

    public IActionResult Result()
    {
        return View();
    }
    

    public IActionResult Result(Calculator model)
    {
        if (!model.IsValid())
        {
            return View("Error");
        }
        return View(model);
    }
    
}