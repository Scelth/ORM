using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Filtration
{
    internal class StoreDbContext : DbContext
    {
        public DbSet<Game> Game { get; set; }

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
            var game = modelBuilder.Entity<Game>();

            // primary key
            game.HasKey(x => x.ID);

            // Not null
            game.Property(x => x.Name).IsRequired();
            game.Property(x => x.Studio).IsRequired();
            game.Property(x => x.Description).IsRequired();
            game.Property(x => x.Price).IsRequired();
        }
    }
}
