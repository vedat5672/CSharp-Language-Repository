using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web_UnderTheHood.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential credential { get; set; }


        public void OnGet()
        {

        }
        public async Task<IActionResult> OnpostAsync()
        {
            if (!ModelState.IsValid) return Page();
            // Verify the Credential
            if (credential.UserName == "admin" & credential.Password == "123")
            {
                //Creating the security context
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"admin"),
                    new Claim(ClaimTypes.Email,"admin@gmail.com"),
                    new Claim("Department","HR"),
                    new Claim("Admin","true"),
                    new Claim("Manager","true"),
                    new Claim("EmploymentDate","2022-05-15")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = credential.RememberMe
                };
                await HttpContext.SignInAsync("MyCookieAuth", principal,authProperties);
                return RedirectToPage("/Index");
            }
            return Page();

        }
    }
    public class Credential
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
