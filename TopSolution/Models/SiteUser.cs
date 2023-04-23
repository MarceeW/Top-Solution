using Microsoft.AspNetCore.Identity;

namespace TopSolution.Models
{
    public class SiteUser : IdentityUser
    {
        public string? FirstName { get;set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
