using DPLK.Controllers.Home;
using DPLK.Models.Dto;
using DPLK.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Graph.Models;
using System.Security.Claims;
using System;
using System.Collections.Generic;

namespace DPLK.Controllers.Account
{

    [Route("account")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private const string SessionName = "_Name";

        public AccountController(IAccountService accountService)
        {

            _accountService = accountService;
        }

        [HttpGet("login")]
/*        [AllowAnonymous]
*/        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var loginResult = await _accountService.LoginAsync(model.Email, model.Password);
                //if (loginResult == null)

                //    throw new System.Exception();
                //var login = new Login(); 
                //login.Email = model.Email;

                //var claims = new List<Claim>
                //{
                //    new Claim(ClaimTypes.Name, model.Email),
                //    // Add additional claims as needed
                //};

                //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                //var authProperties = new AuthenticationProperties
                //{
                //    // Set additional authentication properties if needed
                //};

                //await HttpContext.SignInAsync(
                //    CookieAuthenticationDefaults.AuthenticationScheme,
                //    new ClaimsPrincipal(claimsIdentity),
                //    authProperties);


                try
                {
                    var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, result.Principal);

                if (loginResult)
                         {
                        var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Email),
                    // Add additional claims as needed
                };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        var authProperties = new AuthenticationProperties
                        {
                            // Set additional authentication properties if needed
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity),
                            authProperties);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Email atau kata sandi tidak valid. Silakan coba lagi.";
                        return RedirectToAction("Login");
                    }
                }
                catch (System.Exception ex)
                {

                    TempData["ErrorMessage"] = "Email atau kata sandi tidak valid. Silakan coba lagi.";
                    return RedirectToAction("Login");
                }


                //try
                //{
                //    //var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

                //    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, result.Principal);
                //    if (loginResult)
                //    {
                //        if(User.Identity.IsAuthenticated){
                //            Response.Redirect("/Home/Index");

                //        }

                //        //HttpContext.Session.SetString(SessionName,"ABCD");
                //        //return RedirectToAction("Index", "Home");
                //        return RedirectToAction(nameof(HomeController.Index), "Home");
                //    }
                //    else
                //    {
                //        TempData["ErrorMessage"] = "Email atau kata sandi tidak valid. Silakan coba lagi.";
                //        return RedirectToAction("Login");
                //    }
                //}
                //catch (System.Exception ex)
                //{

                //    TempData["ErrorMessage"] = "Email atau kata sandi tidak valid. Silakan coba lagi.";
                //    return RedirectToAction("Login");
                //}

            }
            return View(model);
   
        }
    
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}