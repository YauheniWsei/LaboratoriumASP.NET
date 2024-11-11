using System.Net.Sockets;
using LaboratoriumASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;

namespace LaboratoriumASP.NET.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Calculator()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Result([FromForm] Calculator model, string op)
    {
        if (!Enum.TryParse<Calculator.Operators>(op, out var operatorEnum))
        {
            ViewBag.Komunikat = "Nieprawidlowy operator";
            return View(model);
        }
        
        model.Operator = operatorEnum;
        
        double result = model.Calculate();
        ViewBag.Komunikat = "Wynik działania: ";
        return View(model);
    }
    
}