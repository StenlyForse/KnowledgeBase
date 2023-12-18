using MainApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MainApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
