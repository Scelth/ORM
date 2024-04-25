using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Wiki.Model;

namespace Wiki.Context
{
    public class WikiDbContext : DbContext
    {
        public DbSet<Country> Country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder builder = new();

            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("LocalConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var country = modelBuilder.Entity<Country>();

            // primary key 
            country.HasKey(x => x.ID);

            // Not null
            country.Property(x => x.Name).IsRequired();
            country.Property(x => x.Year).IsRequired();
            country.Property(x => x.TypeOfBoard).IsRequired();
            country.Property(x => x.Map).IsRequired();
            country.Property(x => x.Population).IsRequired();
            country.Property(x => x.Area).IsRequired();
            country.Property(x => x.GDP).IsRequired();
            country.Property(x => x.Ruler).IsRequired();
            country.Property(x => x.Anthem).IsRequired();
        }
    }
}
