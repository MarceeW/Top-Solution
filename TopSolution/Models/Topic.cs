#nullable disable
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TopSolution.Models
{
    public enum TopicType
    {
        [Display(Name = "Question")]
        Question,
        [Display(Name = "Solution")]
        Solution
    }
    public class Topic
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        public TopicType Type { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public string RelatedProgLanguages { get; set; }
        public int Views { get; set; }
        [JsonIgnore]
        public virtual ICollection<Comment> Comments { get; set; }
        [JsonIgnore]
        public virtual SiteUser Owner { get; set; }
        public virtual string HashTags { get; set; }
        public Topic()
        {
            Id = Guid.NewGuid().ToString();
            CreateDate = DateTime.Now;
            Views = 0;
        }
    }
}
