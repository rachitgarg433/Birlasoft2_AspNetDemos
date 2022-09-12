using Microsoft.EntityFrameworkCore;
using MyASPDemos.Models;

// Add the following Nuget packages:
//  (a) Microsoft.EntityFrameworkCore.SqlServer         (ver 3.x)
//  (b) Microsoft.EntityFrameworkCore.Tools             (ver 3.x)
// NOTE: ensure that both nuget packages have the same version!

namespace MyASPDemos.Data
{
    public class ApplicationDbContext 
        : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<MyASPDemos.Models.Book> Book { get; set; }

        public DbSet<MyASPDemos.Models.Author> Author { get; set; }

       
    }
}
    
