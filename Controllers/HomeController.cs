using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assign1PROG30000.Models;

namespace Assign1PROG30000.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult AvailableEquipment()
    {
        var availableList = EquipmentRepository.GetAll().Where(e => e.IsAvailable);
        return View(availableList);
    }
    public IActionResult Requests()
    {
        var requests = RequestRepository.GetAll();
        return View(requests);
    }
}
