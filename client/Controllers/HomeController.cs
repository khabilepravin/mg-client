﻿using client.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace client.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public  IActionResult Index()
        {
            // If the user is authenticated, then this is how you can get the access_token and id_token
            //if (User.Identity.IsAuthenticated)
            //{
            //    string accessToken = await HttpContext.GetTokenAsync("access_token");

            //    // if you need to check the access token expiration time, use this value
            //    // provided on the authorization response and stored.
            //    // do not attempt to inspect/decode the access token
            //    DateTime accessTokenExpiresAt = DateTime.Parse(
            //        await HttpContext.GetTokenAsync("expires_at"),
            //        CultureInfo.InvariantCulture,
            //        DateTimeStyles.RoundtripKind);

            //    string idToken = await HttpContext.GetTokenAsync("id_token");

            //    // Now you can use them. For more info on when and how to use the
            //    // access_token and id_token, see https://auth0.com/docs/tokens
            //}

            return View();
        }

        [Route("callback")]
        public IActionResult Callback(string token)
        {
            //var c = User.Identity;

            var s = new { Token = token };
            //if (User.Identity.IsAuthenticated)
                //string idToken = await HttpContext.GetTokenAsync("id_token");

            return View("Callback", s);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
