using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReiNona.Models;

namespace ReiNona.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [Route("Portfolio")]
    public IActionResult Portfolio()
    {
        return View();
    }

    [Route("SobreMi")]
    public IActionResult SobreMi()
    {
        return View();
    }

    [Route("Contacto")]
    public IActionResult Contacto()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
