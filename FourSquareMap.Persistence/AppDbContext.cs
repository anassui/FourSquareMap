using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FourSquareMap.Persistence
{
    public class AppDbContext : DbContext 
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("Default"));
        }

    }
}