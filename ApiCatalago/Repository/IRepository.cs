using System.Linq.Expressions;

namespace ApiCatalago.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
        T GetByID(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
