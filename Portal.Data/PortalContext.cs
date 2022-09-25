using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portal.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Data
{
    public class PortalContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public PortalContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("PortalDb"));
            }
        }


        public DbSet<Organization> Organizations { get; set; }
        public DbSet<IdentityProvider> IdentityProviders { get; set; }
        public DbSet<User> Users { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Organization>()
                .HasData(
                    new Organization { Id = 1, Name = "TylerHarker Org" }
                );
        }
    }
}
