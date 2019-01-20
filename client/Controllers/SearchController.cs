using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}