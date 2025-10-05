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
        var allRequests = RequestRepository.GetAll();
        return View(allRequests); 
    }

    public IActionResult AllEquipment()
    {
        var equipmentList = EquipmentRepository.GetAll();
        return View(equipmentList);
    }
    [HttpGet]
    public IActionResult RequestForm()
    {
        var model = new EquipmentRequest(); // optional, just to pass an empty model
        return View(model);
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult RequestForm(EquipmentRequest request)
    {
        if (!ModelState.IsValid)
        {
            return View(request);
        }

        RequestRepository.Add(request);

        return RedirectToAction("Confirmation");
    }
    public IActionResult Confirmation()
    {
        ViewData["Message"] = "Your request has been submitted! Someone from IT will contact you soon.";
        return View();
    }
}
