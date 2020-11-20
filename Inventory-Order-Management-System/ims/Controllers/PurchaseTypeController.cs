using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ims.Controllers
{
    [Authorize(Roles = Pages.MainMenu.PurchaseType.RoleName)]
    public class PurchaseTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}