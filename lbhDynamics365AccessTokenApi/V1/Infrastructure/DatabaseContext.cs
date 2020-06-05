using lbhDynamics365AccessTokenApi.V1.Domain;
using lbhDynamics365AccessTokenApi.V1.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace lbhDynamics365AccessTokenApi.V1.Infrastructure
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DatabaseEntity> DatabaseEntities { get; set; }
    }
}
