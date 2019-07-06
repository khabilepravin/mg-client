using apiProxy.impl;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class ExploreController : Controller
    {
        private readonly IMediaApi _mediaApi;
        public ExploreController(IMediaApi mediaApi)
        {
            _mediaApi = mediaApi;
        }

        [Route("/explore/all")]
        public async Task<IActionResult> All()
        {
            var allMedia = await _mediaApi.GetAllMedia();

            return View("AllMedia", allMedia);
        }
    }
}