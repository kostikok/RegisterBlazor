using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace werver.Models
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IfonvizinContext context) : base(context)
        {
        }

        public async Task<List<User>> FindAll()
        {
            return await base.FindAllAsync();
        }

        public async Task<User> FindById(int id)
        {
            return (User)await base.FindByCondition(x => x.UserId == id);
        }

        public void Create(User entity)
        {
            base.Create(entity);
        }

        public void Update(User entity)
        {
            base.Update(entity);
        }

        public void Delete(User entity)
        {
            base.Delete(entity);
        }

        public async Task<User> GetByEmailAndPassword(string email, string password)
        {
            var result = await base.FindByCondition(x => x.Email == email && x.PasswordHash == password);
            return result.FirstOrDefault();
        }
    }
}
