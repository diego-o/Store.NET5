using System;

namespace Store.Repository.DataAcess.Interfaces
{
    public interface IDataAcess
    {
        IStoreContext StoreContext { get; }

        void Delete<TEntity>(TEntity entity) where TEntity : class;
        TEntity Find<TEntity>(Func<TEntity, bool> predicate) where TEntity : class;
        TEntity Insert<TEntity>(TEntity entity) where TEntity : class;
        TEntity Update<TEntity>(TEntity entity) where TEntity : class;
    }
}
