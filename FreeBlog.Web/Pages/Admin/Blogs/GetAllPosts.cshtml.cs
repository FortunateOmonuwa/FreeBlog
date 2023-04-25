using FreeBlog.Web.DataAccess.DBContext;
using FreeBlog.Web.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreeBlog.Web.Pages.Admin.Blogs
{
    public class GetAllPostsModel : PageModel
    {
        private readonly FreeBlogContext _context;
        public ICollection<BlogPost> Posts { get; set; }

        public GetAllPostsModel(FreeBlogContext context)
        {
            _context = context;
        }
        public async Task OnGet()
        {
           Posts = await _context.BlogPosts.ToListAsync();
        }
    }
}
