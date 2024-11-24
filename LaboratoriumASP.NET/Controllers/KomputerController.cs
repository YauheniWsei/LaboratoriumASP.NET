using LaboratoriumASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaboratoriumASP.NET.Controllers;

public class KomputerController : Controller
{
    [HttpGet]
    public IActionResult CreateForm()
    {
        return View();
    }
    
    static Dictionary<int, Komputer> _komputers = new Dictionary<int, Komputer>();

    
        
    [HttpGet]
    public IActionResult Edit(int id)
    {
        if(_komputers.Keys.Contains(id))
        {
            return View(_komputers[id]);
        }
        else
        {
            return NotFound();
        }
    }
    
    [HttpGet]
    public IActionResult Delete(int id)
    {
        if(_komputers.Keys.Contains(id))
        {
            return View(_komputers[id]);
        }
        else
        {
            return NotFound();
        }
    }
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        if(_komputers.Keys.Contains(id))
        {
            return View(_komputers[id]);
        }
        else
        {
            return NotFound();
        }
    }
    
    [HttpPost]
    public IActionResult Delete(Komputer komputer)
    {
            if (_komputers.Keys.Contains(komputer.Id))
            {
                _komputers.Remove(komputer.Id);
               return RedirectToAction("Index"); 
            }
            return NotFound();
    }
    
    [HttpPost]
    public IActionResult Edit(Komputer komputer)
    {
        if(ModelState.IsValid)
        {
            if(_komputers.Keys.Contains(komputer.Id))
            {
                _komputers[komputer.Id] = komputer;
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
        return View(komputer);

    }

    
    public IActionResult Index()
    {
        return View(_komputers.Values.ToList());
    }

    [HttpPost]
    public IActionResult CreateForm(Komputer komputer)
    {
        if (ModelState.IsValid)
        {
            int id = _komputers.Keys.Count != 0 ? _komputers.Keys.Max() + 1 : 1;

            komputer.Id = id;
            _komputers.Add(id, komputer); 

            return RedirectToAction("Index");
        }
        else
        {
            return View(komputer);
        }
    }
}