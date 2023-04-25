#nullable disable
using System.ComponentModel.DataAnnotations;

namespace TopSolution.Models
{
    public enum TopicType
    {
        Question, Solution
    }
    public class Topic
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        public virtual SiteUser Owner{ get; set; }
        [Required]
        public TopicType Type { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public Topic()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
