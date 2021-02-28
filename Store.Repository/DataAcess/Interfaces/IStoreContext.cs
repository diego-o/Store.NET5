using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.CodeAnalysis;
using Store.Entities.Register;


namespace Store.Repository.DataAcess.Interfaces
{
    public interface IStoreContext
    {
        DbSet<User> Users { get; set; }

        int SaveChanges();
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry<TEntity> Update<TEntity>([NotNull] TEntity entity) where TEntity : class;
    }
}
