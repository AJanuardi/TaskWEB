using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class AppDbContext : DbContext
    {
         public DbSet<Cart> Carts {get; set;}
         public DbSet<Cookie> Cookies {get; set;}

    public AppDbContext(DbContextOptions options) : base (options) 
    {

    }
    }
}