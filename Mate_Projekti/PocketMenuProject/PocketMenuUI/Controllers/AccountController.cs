using Microsoft.AspNetCore.Mvc;

namespace PocketMenuUI.Controllers
{
    public class AccountController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}