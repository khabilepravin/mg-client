using apiProxy.impl;
using apiProxy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaApi _mediaApi;
        private readonly ISearchApi _searchApi;
        private readonly ITextApi _textApi;
        public MediaController(IMediaApi mediaApi, ISearchApi searchApi, ITextApi textApi)
        {
            _mediaApi = mediaApi;
            _searchApi = searchApi;
            _textApi = textApi;
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


        [Route("/movies/popularquotes/{mediaId}/{name}")]
        [HttpGet]
        public async Task<IActionResult> GetPopularTextFromMediaId([FromRoute]string mediaId, [FromRoute]string name)
        {
            var result = await _textApi.GetMediaPopularTextById(mediaId);

            return View("PopularText", result);
        }

        [Route("/movies/search/{name}")]
        [HttpGet]
        public async Task<IActionResult> SearchMedia(string name)
        {
            var response = await _searchApi.SearchMedia(name);

            return View("SearchResults", response);
        }

        [Route("/movies/search/{id}/{searchText}")]
        [HttpGet]
        public async Task<IActionResult> SearchTextInMovies([FromRoute]string id, [FromRoute]string searchText)
        {
            var response = await  _searchApi.SearchTextInMedia(id, searchText);
            return Ok(response);
        }
    }
}