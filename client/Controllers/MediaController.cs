using apiProxy.impl;
using client.Models;
using Microsoft.AspNetCore.Http;
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
            return View("MediaIndex");
        }

        [HttpPost]
        public async Task<IActionResult> PostMedia([FromBody]dynamic media, IFormFile file)
        {
            var f = file;
            
            var m = media;

            await Task.CompletedTask;

            return Ok();
        }
    }
}