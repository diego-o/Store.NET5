using System;
using System.Linq;
using Store.Repository.DataAcess.Interfaces;

namespace Store.Repository.DataAcess
{
    public class DataAcess : IDataAcess
    {
        private readonly IStoreContext _storeContext;

        public IStoreContext StoreContext => _storeContext;

        public DataAcess(IStoreContext storeContext) =>
            _storeContext = storeContext;

        public TEntity Insert<TEntity>(TEntity entity) where TEntity : class
        {
            _storeContext.Set<TEntity>().Add(entity);
            _storeContext.SaveChanges();
            return entity;
        }

        public TEntity Update<TEntity>(TEntity entity) where TEntity : class
        {
            _storeContext.Set<TEntity>().Update(entity);
            _storeContext.SaveChanges();
            return entity;
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            _storeContext.Set<TEntity>().Remove(entity);
            _storeContext.SaveChanges();
        }

        public TEntity Find<TEntity>(Func<TEntity, bool> predicate) where TEntity : class
        {
            return _storeContext.Set<TEntity>().FirstOrDefault(predicate);
        }
    }
}
