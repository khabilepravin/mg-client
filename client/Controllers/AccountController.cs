using client.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace client.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [Route("/account/login")]
        public async Task Login(string returnUrl = "/")
        {
            await HttpContext.ChallengeAsync("Auth0", new AuthenticationProperties() { RedirectUri = returnUrl });
        }

        [Authorize]
        [Route("/account/logout")]
        public async Task Logout()
        {
            // Sign the user out of the cookie authentication middleware (i.e. it will clear the local session cookie)
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Construct the post-logout URL (i.e. where we'll tell Auth0 to redirect after logging the user out)
            var request = HttpContext.Request;
            string postLogoutUri = request.Scheme + "://" + request.Host + request.PathBase + Url.Action("Index", "Home");

            // Redirect to the Auth0 logout endpoint in order to log out of Auth0
            string logoutUri = $"https://{_configuration["Auth0:Domain"]}/v2/logout?client_id={_configuration["Auth0:ClientId"]}&returnTo={Uri.EscapeDataString(postLogoutUri)}";
            HttpContext.Response.Redirect(logoutUri);
            
        }

        [Authorize]
        public IActionResult Profile()
        {
            return View(new UserProfileViewModel()
            {
                Name = User.Identity.Name,
                EmailAddress = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
                ProfileImage = User.Claims.FirstOrDefault(c => c.Type == "picture")?.Value
            });
        }


        /// <summary>
        /// This is just a helper action to enable you to easily see all claims related to a user. It helps when debugging your
        /// application to see the in claims populated from the Auth0 ID Token
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Claims()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}