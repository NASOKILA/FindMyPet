using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindMyPet.Data;
using FindMyPet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FindMyPet.Web.Areas.Admin.Pages.PetsPages
{
    public class AllUsersModel : PageModel
    {
        public List<User> AllUsers { get; set; }

        public IActionResult OnGet()
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return Redirect("/Identity/Account/Login");
            }

            bool isLoggedIn = false;
            bool isAdmin = false;

            var currentUser = this.User;
            if (currentUser.Identity.IsAuthenticated)
            {
                isLoggedIn = true;
                isAdmin = currentUser.Claims.Any(c => c.Value == "Admin");
                if (!isAdmin)
                {
                    return new RedirectToActionResult("All", "Pets", new { @area = "" });
                }
            }

            ViewData["LoggedIn"] = isLoggedIn.ToString();
            ViewData["IsAdmin"] = isAdmin.ToString();


            using (var context = new FindMyPetDbContext())
            {
                var users = context.Users
                    .ToList();
                
                this.AllUsers = users.Where(u => u.Email != this.User.Identity.Name).ToList();
                ViewData["UserList"] = users;
                return Page();
            }
        }
    }
}
