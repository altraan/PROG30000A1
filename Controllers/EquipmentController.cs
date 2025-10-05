using Microsoft.AspNetCore.Mvc;
using Assign1PROG30000.Models;

namespace Assign1PROG30000.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult AllEquipment()
        {
            var equipmentList = EquipmentRepository.GetAll();
            return View(equipmentList);
        }
    }
}
