using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeBlog.Web.Domain.Models
{
    public class BlogPostTag
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(BlogPost))]
        public Guid BlogPostId { get; set; }
    }
}
