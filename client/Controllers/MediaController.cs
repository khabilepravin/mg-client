using apiProxy.impl;
using client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
            return View("MediaIndex", new Media());
        }

        [HttpPost]
        public async Task<IActionResult> PostMedia([FromForm]Media media)
        {
            var mediaId = await _mediaApi.PostMedia(media);

            return Ok(mediaId);
        }
    }
}