using Microsoft.EntityFrameworkCore;
using CancerCare.WebApp.Models;

namespace CancerCare.WebApp.Models
{
    public class CancerCareDbContext : DbContext
    {

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<User> Users { get; set; }
        
        public CancerCareDbContext(DbContextOptions<CancerCareDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

       
        
        
    }
}
