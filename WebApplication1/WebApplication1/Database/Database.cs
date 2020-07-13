using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication1.Database
{
    public class MyDatabase : DbContext, IDatabase
    {
        public DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbUser = Environment.GetEnvironmentVariable("DB_USER") ?? "";
            var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "";
            var dbHost = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            var dbPort = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
            var dbName = "postgres";

            var connectionString = $"User Id={dbUser};Host={dbHost};Port={dbPort};Password={dbPassword};Database={dbName};";

            optionsBuilder.UseNpgsql(connectionString);
        }

        public void Migrate()
        {
            Database.Migrate();
        }
    }
}
