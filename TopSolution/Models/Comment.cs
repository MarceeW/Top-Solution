#nullable disable
using System.ComponentModel.DataAnnotations;

namespace TopSolution.Models
{
    public class Comment
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public bool IsSolution { get; set; }
        public virtual SiteUser Owner { get; set; }
        public virtual Topic Topic { get; set; }
        public Comment()
        {
            CreatedAt = DateTime.Now;
            Id = Guid.NewGuid().ToString();
        }
    }
}
