using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Faded.Models;

namespace Faded.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Product()
    {
        return View();
    }
    public IActionResult Vintage()
    {
        return View();
    }
    public IActionResult Sale()
    {
        return View();
    }
    public IActionResult Information()
    {
        return View();
    }
    public IActionResult Jersey()
    {
        return View();
    }
    public IActionResult Cart()
    {
        return View();
    }
    public IActionResult Footwear()
    {
        return View();
    }
     public IActionResult Index()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
