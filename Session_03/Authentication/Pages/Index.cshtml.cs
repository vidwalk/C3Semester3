using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Authentication.Pages
{
    public class IndexModel : PageModel
    {
        public async Task<IActionResult> OnPostLoginAsync(string name)
        {
            List<Claim> claims;
            if(name == "admin")
                claims = new List<Claim>{
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Role, "admin")
            };
            else
                claims = new List<Claim>{
                new Claim(ClaimTypes.Name, name)
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            return RedirectToPage("/Index");
        }
        

        [Authorize]
        public async Task<IActionResult> OnPostLogoutAsync(string name)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Index");
        }
    }
}
