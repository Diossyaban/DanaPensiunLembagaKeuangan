using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DPLK.Models.Dto;
using DPLK.Service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPLK.Controllers.Account
{
    [Route("account")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var loginResult = await _accountService.LoginAsync(model.Email, model.Password);

                    if (loginResult)
                    {
                        var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Email),
                };

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        var authProperties = new AuthenticationProperties
                        {
                        };

                        await HttpContext.SignInAsync(
                            CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity),
                            authProperties);

                        Response.Cookies.Append("LoginSuccessMessage", $"Login successful! Welcome, {model.Email}.", new CookieOptions

                        {
                            HttpOnly = true,
                            SameSite = SameSiteMode.Strict
                        });

                        TempData.Remove("SuccessMessage");

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Email atau kata sandi tidak valid. Silakan coba lagi.";
                    }
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = "Terjadi kesalahan. Silakan coba lagi.";
                }
            }

            return RedirectToAction("Login");
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            var userEmail = User.Identity.Name; 
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            Response.Cookies.Append("LogoutMessage", $"Goodbye, {userEmail}. You have been successfully logged out.", new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Strict
            });

            return RedirectToAction("Login");
        }

    }
}
