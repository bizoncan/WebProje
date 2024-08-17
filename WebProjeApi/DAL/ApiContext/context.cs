
using Microsoft.EntityFrameworkCore;
using WebProjeApi.DAL.Entity;

namespace WebProjeApi.DAL.ApiContext
{
    public class context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8OU0GKQ\\SQLEXPRESS;database= WebProjeDB2;integrated security = true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
