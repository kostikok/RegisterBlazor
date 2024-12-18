using System.Threading.Tasks;

namespace werver.Models
{
    public class UserService : IUserService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public UserService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<User>> GetAll()
        {
            return await _repositoryWrapper.User.FindAll();
        }

        public async Task<User> GetById(int id)
        {
            return await _repositoryWrapper.User.FindById(id);
        }

        public async Task Create(User model)
        {
            _repositoryWrapper.User.Create(model);
            await _repositoryWrapper.Save();
        }

        public async Task Update(User model)
        {
            _repositoryWrapper.User.Update(model);
            await _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var user = await _repositoryWrapper.User.FindById(id);
            if (user != null)
            {
                _repositoryWrapper.User.Delete(user);
                await _repositoryWrapper.Save();
            }
        }

        public async Task<User> Login(string email, string password)
        {
            var user = await _repositoryWrapper.User.GetByEmailAndPassword(email, password);
            return user;
        }
    }
}
