using Users.Core.Interfaces;
using Users.Core.Models;

namespace Users.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddUserAsync(User user)
        {
            await _repository.AddAsync(user);
        }
    }
}

