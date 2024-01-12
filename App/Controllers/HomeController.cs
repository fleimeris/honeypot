using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Recipe1()
    {
        return View();
    }

    public IActionResult Recipe2()
    {
        return View();
    }

    public IActionResult Recipe3()
    {
        return View();
    }

    public IActionResult Recipe4()
    {
        return View();
    }

    public IActionResult Recipe5()
    {
        return View();
    }

    public IActionResult LoginAction()
    {
        Console.WriteLine("test");

        return View("Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}