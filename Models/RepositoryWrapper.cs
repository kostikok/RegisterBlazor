namespace werver.Models
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly IfonvizinContext _context;
        private IUserRepository _user;

        public RepositoryWrapper(IfonvizinContext context)
        {
            _context = context;
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _user;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
