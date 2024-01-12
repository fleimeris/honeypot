using System.Diagnostics;
using App.Context.Models;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using AppContext = App.Context.AppContext;

namespace App.Controllers;

public class HomeController : Controller
{
    private readonly AppContext _appContext;

    public HomeController(AppContext appContext)
    {
        _appContext = appContext;
    }

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
        var loginEntry = new Login
        {
            Id = Guid.NewGuid(),
            Username = username,
            Password = password
        };

        _appContext.Add(loginEntry);
        _appContext.SaveChanges();

        return RedirectToAction("Login", "Home");
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