using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    public class NumberSequenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}