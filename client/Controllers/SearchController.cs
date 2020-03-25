using apiProxy.impl;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class SearchController : Controller
    {
       private readonly ISearchApi _searchApi;
        public SearchController(ISearchApi searchApi)
        {
            _searchApi = searchApi;
                
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SearchQuotes(string quotePartial)
        {
            var response = await _searchApi.SearchText(quotePartial);

            return View("results", response);
        }

        [HttpGet]
        public async Task<IActionResult> SearchMedia(string mediaText)
        {
            var response = await _searchApi.SearchMedia(mediaText);

            return Json(response);
        }
    }
}