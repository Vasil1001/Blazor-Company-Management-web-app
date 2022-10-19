using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tera.Server.Models;

namespace Tera.Server.Controllers
{
    public class AspnetUser : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AspnetUser(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = userManager.Users;
            return View(users);
        }
    }
}
