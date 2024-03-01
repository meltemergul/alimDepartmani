using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace alimDepartmani.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));

        public DbSet<Employee> Employees { get; set; }
    }
}
