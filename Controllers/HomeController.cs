using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assign1PROG30000.Models;
using Assign1PROG30000.Models.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Assign1PROG30000.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEquipmentRepository _equipmentRepository;
    private readonly IRequestRepository _requestRepository;

    public HomeController(ILogger<HomeController> logger, IEquipmentRepository equipmentRepository, IRequestRepository requestRepository)
    {
        _logger = logger;
        _equipmentRepository = equipmentRepository;
        _requestRepository = requestRepository;
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
        var availableList = _equipmentRepository.GetAll().Where(e => e.IsAvailable);
        return View(availableList);
    }

    public IActionResult Requests()
    {
        var allRequests = _requestRepository.GetAll();
        return View(allRequests);
    }

    public IActionResult AllEquipment()
    {
        var equipmentList = _equipmentRepository.GetAll();
        return View(equipmentList);
    }
    
    [HttpGet]
    public ViewResult RequestForm()
    {
        var availableEquipments = _equipmentRepository.GetAvailable() ?? new List<Equipment>();

        var model = new EquipmentRequest();
        model.Equipments = _equipmentRepository.GetAvailable() ?? new List<Equipment>();
        
        return View(model);
    }


    [HttpPost]
    public ViewResult RequestForm(EquipmentRequest equipmentRequest)
    {
        if (!ModelState.IsValid)
        {
            equipmentRequest.Equipments = _equipmentRepository.GetAvailable();
            return View(equipmentRequest);
        }
        _requestRepository.Add(equipmentRequest);
        return View("Confirmation");
    }
} 
