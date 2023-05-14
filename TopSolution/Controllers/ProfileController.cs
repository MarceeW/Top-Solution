using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TopSolution.Data;
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
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UploadProfilePicture([FromForm]IFormFile profilePicture)
        {
            using(var stream = profilePicture.OpenReadStream())
            {
                var buffer = new byte[stream.Length];
                await stream.ReadAsync(buffer);
                var user = await _userManager.GetUserAsync(User);

                user!.ProfilePicture = buffer;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
