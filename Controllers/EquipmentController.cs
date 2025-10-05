using Microsoft.AspNetCore.Mvc;
using Assign1PROG30000.Models;

namespace Assign1PROG30000.Controllers
{
    public class EquipmentController : Controller
    {
        [HttpGet("/RequestForm")]
        public IActionResult RequestForm()
        {
            return View();
        }

        [HttpPost("/RequestForm")]
        public IActionResult RequestForm(EquipmentRequest request)
        {
            if (ModelState.IsValid)
            {
                RequestRepository.Add(request);
                return RedirectToAction("Confirmation", new { id = request.Id });
            }

            return View(request);
        }

        public IActionResult Confirmation(int id)
        {
            ViewBag.RequestId = id;
            return View();
        }
    }
}
