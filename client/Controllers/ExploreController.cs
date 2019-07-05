using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    public class ExploreController : Controller
    {
        [Route("/explore/categories")]
        public IActionResult Categories()
        {
            return View();
        }
    }
}