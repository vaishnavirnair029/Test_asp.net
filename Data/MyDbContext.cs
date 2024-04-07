using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base (options) {
        
        }
        public DbSet<LoginViewModel> Login { get; set; }
        public DbSet<RegisterModel> StudentDetails { get; set; }


    }
    


}
