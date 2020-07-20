using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace WebApplication1.Database
{
    public class MyDatabase : DbContext, IDatabase
    {
        public DbSet<Model> Models { get; set; }

        private readonly IConfiguration _config;

        public MyDatabase(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbUser = _config["Database:DB_USER"] ?? "";
            var dbPassword = _config["Database:DB_PASSWORD"] ?? "";
            var dbHost = _config["Database:DB_HOST"] ?? "localhost";
            var dbPort = _config["Database:DB_PORT"] ?? "5432";
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
