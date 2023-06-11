using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopSolution.Data;
using TopSolution.Data.Migrations;
using TopSolution.Models;

namespace TopSolution.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public ProfileController(ILogger<HomeController> logger, UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public async Task<IActionResult> Index(string id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
                ViewData["isOwnProfile"] = user!.Id == id || id == null;
            else ViewData["isOwnProfile"] = false;

            if (id != null)
                return View(await _userManager.FindByIdAsync(id));
            else return View(user);
        }
        public async Task<IActionResult> List(string query)
        {
            if (query != null)
                return View(await _userManager.Users.Where(u => u.DisplayName.StartsWith(query)).ToListAsync());
            return View(await _userManager.Users.ToListAsync());
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UploadProfilePicture([FromForm]IFormFile profilePicture)
        {
            using(var stream = profilePicture.OpenReadStream())
            {
                var buffer = new byte[stream.Length];
                await stream.ReadAsync(buffer);
                var user = await _userManager.GetUserAsync(User);

                string filename = user!.Id + '.' + profilePicture.FileName.Split('.')[1];

                if(user.ProfilePicturePath != null)
                    System.IO.File.Delete(Path.Combine("wwwroot", "profilepictures", user.ProfilePicturePath));

                System.IO.File.WriteAllBytes(Path.Combine("wwwroot", "profilepictures", filename), buffer);

                user!.ProfilePicturePath = filename;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
