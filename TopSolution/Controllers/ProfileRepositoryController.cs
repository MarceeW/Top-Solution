using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TopSolution.Data;
using TopSolution.Models;

namespace TopSolution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileRepositoryController : ControllerBase
    {
        private readonly UserManager<SiteUser> _userManager;
        public class ProfileData
        {
            public string? Id { get; set; }
            public string? DisplayName { get; set; }
        }
        public ProfileRepositoryController(UserManager<SiteUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<ProfileData> GetProfileData()
        {
            var data = _userManager.Users.Select(u =>  new ProfileData { Id = u.Id, DisplayName = u.DisplayName });
            return data;
        }
    }
}
