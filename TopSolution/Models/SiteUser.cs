#nullable disable
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopSolution.Models
{
    public class SiteUser : IdentityUser
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get;set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
        public SiteUser()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
