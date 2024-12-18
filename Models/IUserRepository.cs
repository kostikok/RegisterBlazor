namespace werver.Models
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<List<User>> FindAll();
        Task<User> FindById(int id);
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
        Task<User> GetByEmailAndPassword(string email, string password);
    }
}
