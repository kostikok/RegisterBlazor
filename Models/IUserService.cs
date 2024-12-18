namespace werver.Models
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task<User> GetById(int id);
        Task Create(User model);
        Task Update(User model);
        Task Delete(int id);
        Task<User> Login(string email, string password);
    }
}
