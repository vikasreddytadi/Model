using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using model.Models;

namespace model.Data
{
    public class EntityFramework : DbContext
    {
        public DbSet<num>? num { get; set; }

        private IConfiguration _config;

        public EntityFramework(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured && _config.GetConnectionString("Default") != null)
            {
                options.UseSqlServer(
                    _config.GetConnectionString("Default"),
                    options => options.EnableRetryOnFailure()
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<num>().HasKey(key => key.id);
        }
    }
}
