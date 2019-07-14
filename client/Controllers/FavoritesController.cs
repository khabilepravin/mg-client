using apiProxy.impl;
using client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly IUserFavoriteApi _userFavoriteApi;
        public FavoritesController(IUserFavoriteApi userFavoriteApi)
        {
            _userFavoriteApi = userFavoriteApi;
        }

        public IActionResult Top()
        {
            return View();
        }

        //[Authorize]
        public IActionResult My(string userId)
        {
            return View();
        }

        [Route("/favorites/add")]
        [HttpPost]
        public async Task<IActionResult> AddToFavorite([FromBody]FavoriteAddModel favoriteAddModel)
        {
            var id = await _userFavoriteApi.AddToFavorite(favoriteAddModel.UserId, favoriteAddModel.ParsedTextId);

            return Ok(id);
        }
    }
}