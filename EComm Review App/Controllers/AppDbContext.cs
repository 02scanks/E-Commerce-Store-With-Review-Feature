using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EComm_Review_App.Controllers
{
    internal class AppDbContext : DbContext
    {
        private static readonly string CONNECTIONSTRING = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(CONNECTIONSTRING, ServerVersion.AutoDetect(CONNECTIONSTRING));
        }

    }
}
