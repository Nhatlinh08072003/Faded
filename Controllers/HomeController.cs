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

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Vintageteeshop()
    {
        return View();
    }
    public IActionResult Reword()
    {
        return View();
    }
    public IActionResult Information()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Cart()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
