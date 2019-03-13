using apiProxy.impl;
using apiProxy.Models;
using client.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaApi _mediaApi;
        private readonly ISearchApi _searchApi;
        public MediaController(IMediaApi mediaApi, ISearchApi searchApi)
        {
            _mediaApi = mediaApi;
            _searchApi = searchApi;
        }

        [Route("/media/index")]
        public IActionResult Index()
        {
            return View("MediaIndex", new Media());
        }

        [Route("/media/postmedia")]
        [HttpPost]
        public async Task<IActionResult> PostMedia([FromForm]Media media)
        {
            //using (var reader = new StreamReader(media.FilesubtitleFile.OpenReadStream()))
            //{
            //    media.MediaText = await reader.ReadToEndAsync();
            //}

            var mediaId = await _mediaApi.PostMedia(media);

            return Ok(mediaId);
        }

        [HttpGet]
        public async Task<IActionResult> GetMediaText([FromRoute]string mediaId)
        {
            var mediaText = await _mediaApi.GetMediaText(mediaId);

            return Ok(mediaText);
        }

        [Route("/movies/search/{name}")]
        [HttpGet]
        public async Task<IActionResult> SearchMedia(string name)
        {
            var response = await _searchApi.SearchMedia(name);

            return View("SearchResults", response);
        }
    }
}