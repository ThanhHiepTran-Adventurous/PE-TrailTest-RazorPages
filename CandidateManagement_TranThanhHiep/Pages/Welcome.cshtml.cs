using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagement_TranThanhHiep.Pages
{
    public class WelcomeModel : PageModel
    {
        public string Email { get; set; }

        public void OnGet()
        {
            Email = HttpContext.Session.GetString("email");
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("email");
            return RedirectToPage("Index");
        }
    }
}