using System.Linq.Expressions;

namespace werver.Models
{
    public interface IRepositoryBase<T>
    {
        Task<List<T>> FindAllAsync();
        Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task Save();
    }
}
