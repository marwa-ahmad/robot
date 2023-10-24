using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Robot.Model;

namespace Robot.Storage.PostgreSQL
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Execution> Execusions { get; set; }
    }
}
