using Store.Entities.Register;
using Store.Repository.Repositories.Register.Interfaces;
using Store.Service.Register.Interfaces;

namespace Store.Service.Register
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) =>
            _userRepository = userRepository;

        public User GetUserById(int id) =>
            _userRepository.Find(t => t.Id == id);

        public User NewUser(User user) =>
            _userRepository.Insert(user);
    }
}
