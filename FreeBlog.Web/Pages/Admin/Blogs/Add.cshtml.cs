using FreeBlog.Web.DataAccess.DBContext;
using FreeBlog.Web.Domain.Models;
using FreeBlog.Web.Domain.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreeBlog.Web.Pages.Admin.Blogs
{
    public class AddModel : PageModel
    {
        private readonly FreeBlogContext _context;

        [BindProperty]
        public AddBlogPost AddBlogPost { get; set; }
        public AddModel(FreeBlogContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() 
        {
            try
            {
                var post = new BlogPost()
                {
                    Heading = AddBlogPost.Heading,
                    Content = AddBlogPost.Content,
                    PageTitle = AddBlogPost.PageTitle,
                    Description = AddBlogPost.Description,
                    ImageUrl = AddBlogPost.ImageUrl,
                    UrlHandle = AddBlogPost.UrlHandle,
                    PublishedDate = AddBlogPost.PublishedDate,
                    Author = AddBlogPost.Author,
                    Visible = AddBlogPost.Visible,


                };
               await _context.BlogPosts.AddAsync(post);
               await _context.SaveChangesAsync();
                return RedirectToPage("/Admin/Blogs/GetAllPosts");
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //var heading = Request.Form["heading"];
            //var pageTitle = Request.Form["pageTitle"];
            //var content = Request.Form["content"];
            //var description = Request.Form["description"];
        }
    }
}
