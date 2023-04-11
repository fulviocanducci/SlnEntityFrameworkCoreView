using EfViewMysQL.Models.Mappings;
using Microsoft.EntityFrameworkCore;

namespace EfViewMysQL.Models
{
   public sealed class DatabaseContext : DbContext
   {
      public DatabaseContext() { }

      public DatabaseContext(DbContextOptions options) : base(options) { }

      public DbSet<People> People { get; set; }
      public DbSet<PeopleSexCount> PeopleSexCount { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.ApplyConfiguration(new PeopleMapping());
         modelBuilder.ApplyConfiguration(new PeopleSexCountMapping());
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseMySql
            (
               "server=localhost;user=root;password=senha;database=ef",
               new MySqlServerVersion(new Version(8, 0, 31))
            );

         //optionsBuilder.LogTo(Console.WriteLine);
      }
   }
}
