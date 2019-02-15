using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    public class FavoritesController : Controller
    {
        public IActionResult Top()
        {
            return View();
        }

        //[Authorize]
        public IActionResult My(string userId)
        {
            return View();
        }
    }
}