using BarberAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberAPI.Contexts
{
    public class BarberContext : DbContext
    {
        public BarberContext(DbContextOptions<BarberContext> options) : base(options) {}
        
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}