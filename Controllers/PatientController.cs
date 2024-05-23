using Microsoft.AspNetCore.Mvc;

namespace UI_PatientManagementSystem.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
