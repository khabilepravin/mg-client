using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace client.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public async Task Login(string returnUrl = "/")
        {
            await HttpContext.ChallengeAsync("Auth0", new AuthenticationProperties() { RedirectUri = returnUrl });
        }
    }
}