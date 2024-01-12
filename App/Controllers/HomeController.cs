using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult LoginUser(string username, string password)
    {
        Console.WriteLine($"{username} {password}");

        return View("Login");
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}