using Microsoft.EntityFrameworkCore;
using Reiseziele;
using ReiseZiele.Model;

namespace ReiseZiele.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        // DbSet property tells ef core which table to create, if it doesnt already exist
        public DbSet<ReiseZiel> ReiseZiele { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
    }
}
