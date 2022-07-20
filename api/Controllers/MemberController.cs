using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        [HttpGet]
        [Route("/login")]
        public async Task<string> LoginUser(string username, string password){
            var loginValid = ValidateLogin(username, password);
            if (!loginValid)
            {
                return "Invalid Username/Password.";
            }
            else
            {
                await SignInUser(username);
                return "Valid User";
            }
        }

        [HttpGet]
        [Route("/check")]
        public string CheckCookie()
        {
            var username = HttpContext.User.Identity.Name;
            var customClaim = HttpContext.User.FindFirst("MyCustomClaim");
            return $"User {username} has custom claim value: {customClaim.Value}";
        }

        private bool ValidateLogin(string username, string password)
        {
            return true;
        }

        private async Task SignInUser(string username)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim("MyCustomClaim", Guid.NewGuid().ToString())
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));
        }
    }
}
