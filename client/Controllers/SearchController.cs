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

        [HttpGet("{quotePartial}")]
        public async Task<IActionResult> SearchQuotes([FromRoute]string quotePartial)
        {
            var response = await _searchApi.Search(quotePartial);

            return View("results", response);
        }
    }
}