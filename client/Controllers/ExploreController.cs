using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    public class ExploreController : Controller
    {
        public IActionResult Categories()
        {
            return View();
        }
    }
}