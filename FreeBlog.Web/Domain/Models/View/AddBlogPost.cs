using Microsoft.AspNetCore.Mvc;

namespace FreeBlog.Web.Domain.Models.View
{
    public class AddBlogPost
    {
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

    }
}
