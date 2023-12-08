using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DPLK.Models;
using DPLK.Models.context;
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
        private readonly PensionContext _context;

        public AccountController(IAccountService accountService, PensionContext context)
        {
            _accountService = accountService;
            _context = context;
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
                        string ipAddress = GetClientIpAddress();

                        Response.Cookies.Append("LoginSuccessMessage", $"Login successful! Welcome, {model.Email}.");

                        await LogActivity(model.Email, ipAddress, 1, $"User {model.Email} logged in.");

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

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Email or password is invalid. Please try again.");
                    }
                }
                catch (System.Exception ex)
                {
                    TempData["ErrorMessage"] = "An error occurred. Please try again.";
                }
            }

            return View(model);
        }


        private string GetClientIpAddress()
        {
            string ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString();

            if (HttpContext.Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                ipAddress = HttpContext.Request.Headers["X-Forwarded-For"];
            }

            return ipAddress;
        }



        private async Task LogLoginActivity(string email, string ipAddress)
        {
            var logInfo = $"User {email} logged in from IP address {ipAddress}.";
            await LogActivity(email, ipAddress, 1, logInfo);
        }

        private async Task LogActivity(string email, string ipAddress, int activityType, string info)
        {
            var logActivity = new TLogActivity
            {
                Email = email,
                Ipaddress = ipAddress,
                Activitytype = activityType,
                Info = info,
                Timestamp = DateTime.Now
            };

            _context.TLogActivities.Add(logActivity);
            await _context.SaveChangesAsync();
        }


        [HttpGet("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            var userEmail = User.Identity.Name;

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            Response.Cookies.Append("LogoutMessage", $"Goodbye, {userEmail}. You have been successfully logged out.", new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Strict
            });

            await LogActivity(userEmail, GetClientIpAddress(), 2, $"User {userEmail} logged out.");

            return RedirectToAction("Login");
        }
    }
}