using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Outspoken.Model;
namespace Outspoken.Data
{
	public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<List<T>> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        Task<List<T>> GetAll();
        int Count();
        Task<T> GetSingle(int id);
        Task<T> GetSingle(Expression<Func<T, bool>> predicate);
        Task<T> GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<List<T>> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> predicate);
        void Commit();
    }
}
