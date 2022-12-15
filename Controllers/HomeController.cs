using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;

namespace ChefsNDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;
    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {

        return View();
    }

    [HttpGet("chefs")]
    public IActionResult Chefs()
    {   
        List<Chef> AllChefs = _context.Chefs.OrderBy(c=>c.FirstName).ToList();
        return View(AllChefs);
    }

    [HttpGet("dishes")]
    public IActionResult Dishes()
    {
        List<Dish> AllDishes = _context.Dishes.OrderBy(c=>c.Name).ToList();
        return View(AllDishes);
    }

    [HttpGet("chefs/new")]
    public IActionResult NewChef()
    {
        return View();
    }

    [HttpGet("dishes/new")]
    public IActionResult NewDish()
    {   
        ViewBag.AllChefs = _context.Chefs.OrderBy(c=>c.FirstName).ToList();
        return View("NewDish");
    }
        
    [HttpPost("chefs/create")]
    public IActionResult CreateChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            _context.Chefs.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Chefs");
        } else {
            return View("NewChef");
        }
    }

    [HttpPost("dishes/create")]
    public IActionResult CreateDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Dishes.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Dishes");
        } else {
            return NewDish();
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
