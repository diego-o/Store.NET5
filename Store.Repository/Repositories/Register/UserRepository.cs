using System;
using System.Linq;
using Store.Entities.Register;
using Store.Repository.DataAcess.Interfaces;
using Store.Repository.Repositories.Register.Interfaces;

namespace Store.Repository.Repositories.Register
{
    public class UserRepository : IUserRepository
    {
        private readonly IDataAcess _dataAcess;

        public UserRepository(IDataAcess dataAcess) =>
            _dataAcess = dataAcess;

        public User Find(Func<User, bool> predicate) =>
            _dataAcess.Find(predicate);

        public User Insert(User user) =>
            _dataAcess.Insert(user);

        public IQueryable<User> Select() =>
            _dataAcess.StoreContext.Users;


        public User Update(User user) =>
            _dataAcess.Update(user);
    }
}
