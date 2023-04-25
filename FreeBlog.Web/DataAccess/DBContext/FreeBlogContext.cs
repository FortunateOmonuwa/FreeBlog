using FreeBlog.Web.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeBlog.Web.DataAccess.DBContext
{
    public class FreeBlogContext : DbContext
    {
        public FreeBlogContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostTag> Tags { get; set;}
    }
}
