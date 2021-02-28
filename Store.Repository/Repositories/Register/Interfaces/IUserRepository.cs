using System;
using System.Linq;
using Store.Entities.Register;

namespace Store.Repository.Repositories.Register.Interfaces
{
    public interface IUserRepository
    {
        User Insert(User user);
        User Update(User user);
        User Find(Func<User, bool> predicate);
        IQueryable<User> Select();
    }
}
