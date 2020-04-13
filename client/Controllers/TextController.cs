using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiProxy.impl;
using Microsoft.AspNetCore.Mvc;

namespace client.Controllers
{
    public class TextController : Controller
    {
        private readonly ITextApi _textApi;
        public TextController(ITextApi textApi)
        {
            _textApi = textApi;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/text/details/{id}")]
        public async Task<IActionResult> Details([FromRoute]string id)
        {
            var result = await _textApi.GetSurroundingText(id);

            return View(result);
        }
    }
}