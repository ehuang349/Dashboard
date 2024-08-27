using dashboard.server.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Server.Entities
{
    public class DashboardContext : DbContext
    {
        public DashboardContext(DbContextOptions<DashboardContext> options) : base(options) { }


        #region DBSETS
        public DbSet<ApiAccess> ApiAccesses { get; set; }
        #endregion
    }
}
