using dashboard.server.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Server.Entities
{
    public class DashboardContext : DbContext
    {
        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        #region DBSETS
        public DbSet<ApiAccess> ApiAccesses { get; set; }
        public DbSet<WeatherRecord> WeatherRecords { get; set; }
        #endregion
    }
}
