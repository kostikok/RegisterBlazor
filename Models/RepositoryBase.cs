using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace werver.Models
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected IfonvizinContext _context { get; set; }

        public RepositoryBase(IfonvizinContext context)
        {
            _context = context;
        }

        public async Task<List<T>> FindAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().Where(expression).ToListAsync();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
