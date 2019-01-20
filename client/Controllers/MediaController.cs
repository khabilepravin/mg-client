using apiProxy.impl;
using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaApi _mediaApi;
        public MediaController(IMediaApi mediaApi)
        {
            _mediaApi = mediaApi;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}