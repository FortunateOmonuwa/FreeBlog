using FreeBlog.Web.DataAccess.DBContext;
using FreeBlog.Web.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreeBlog.Web.Pages.Admin.Blogs
{
    public class EditPostModel : PageModel
    {
        private readonly FreeBlogContext _context;
        [BindProperty]
        public BlogPost Post { get; set; }

        public EditPostModel(FreeBlogContext context)
        {
            _context = context;
        }
        public async Task OnGet(Guid id)
        {
            try
            {
                Post = await _context.BlogPosts.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
         
        }

        public async Task <IActionResult> OnPostEdit()
        {
            try
            {
                var existingPost = await _context.BlogPosts.FindAsync(Post.Id);
                if (existingPost != null)
                {
                    existingPost.Heading = Post.Heading;
                    existingPost.Content = Post.Content;
                    existingPost.PageTitle = Post.PageTitle;
                    existingPost.Description = Post.Description;
                    existingPost.Author = Post.Author;
                    existingPost.PublishedDate = Post.PublishedDate;
                    existingPost.ImageUrl = Post.ImageUrl;
                    existingPost.UrlHandle = Post.UrlHandle;
                    existingPost.Visible = Post.Visible;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
            await _context.SaveChangesAsync();
            return RedirectToPage("/Admin/Blog/GetAllPosts");
        }

        public async Task <IActionResult> OnPostDelete()
        {
            try
            {
                var existingPost = await _context.BlogPosts.FindAsync(Post.Id);
                if (existingPost != null)
                {
                    _context.BlogPosts.Remove(existingPost);
                    _context.SaveChanges();
                    return RedirectToPage("/Admin/Blog/GetAllPosts");
                }
                else
                {
                    return null;
                }
                return Page();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
        }
    }
}
