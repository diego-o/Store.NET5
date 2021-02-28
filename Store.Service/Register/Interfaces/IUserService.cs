using Store.Entities.Register;

namespace Store.Service.Register.Interfaces
{
    public interface IUserService
    {
        User NewUser(User user);
        User GetUserById(int id);
    }
}
