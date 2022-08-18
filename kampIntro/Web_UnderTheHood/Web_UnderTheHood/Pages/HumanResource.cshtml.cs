using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_UnderTheHood.Pages
{
    [Authorize(Policy = "MustBelongTohrDepartment")]
    public class HumanResourceModel : PageModel
    {
        
        public void OnGet()
        {
        }
    }
}
