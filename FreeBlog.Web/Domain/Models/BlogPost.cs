using System.ComponentModel.DataAnnotations;

namespace FreeBlog.Web.Domain.Models
{
    public class BlogPost
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Heading { get; set; }
        [Required]
        public string PageTitle { get; set; }
        [Required]
        public string Content { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        [Required]
        public string Author { get; set; }
        public bool Visible { get; set; }
    }
}
