using Microsoft.AspNetCore.Mvc;

namespace GCS_DD.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
