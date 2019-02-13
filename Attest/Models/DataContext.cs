using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Attest.Models
{
    public class DataContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();

            optionsBuilder.UseMySql(configuration["ConnectionStrings:DefaultConnection"]);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Nauch_deyat> NauchDeyats { get; set; }
        public DbSet<Zayavlen> Zayavlens { get; set; }
        public DbSet<Obrazovan> Obrazovans { get; set; }
    }
}
