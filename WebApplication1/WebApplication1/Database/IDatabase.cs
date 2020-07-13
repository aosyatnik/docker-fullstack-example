using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Database
{
    public interface IDatabase
    {
        DbSet<Model> Models { get; }

        void Migrate();

        int SaveChanges();
    }
}
