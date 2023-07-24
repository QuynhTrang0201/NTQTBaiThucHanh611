using FirstWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Data;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> option): base(option)
        {

        }
        public DbSet<Student> Students {get; set;}
    }
}