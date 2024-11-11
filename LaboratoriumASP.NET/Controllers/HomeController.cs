using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LaboratoriumASP.NET.Models;

namespace LaboratoriumASP.NET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    //Zadanie domowe
    public IActionResult Age(int m, int d, int y)
    {
        DateTime today = DateTime.Today;
        DateTime birthday = new DateTime(y, m, d);
        int age = today.Year - birthday.Year;
        ViewBag.age = age;
        ViewBag.ageMonth = today.Month - birthday.Month;
        ViewBag.ageDay = today.Day - birthday.Day;
        return View();
    }
    
    public IActionResult Calculator()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}