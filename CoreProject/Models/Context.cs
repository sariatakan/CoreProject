using Microsoft.EntityFrameworkCore;

namespace CoreProject.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-1R2MHBR\\SQLEXPRESS; database=BirimDB; integrated security = true; TrustServerCertificate=True");
        }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Adminlogin> Adminlogins { get; set; }
    }
}
