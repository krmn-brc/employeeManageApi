
using System.Linq.Expressions;
using EmployeeManageAp.Web.Entities.Models.Common;

namespace EmployeeManageAp.Web.Repositories.Common
{
    public interface IRepositoryBase<T>
    where T:class, IEntityBase, new()
    {
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> condition = null!);
        Task<T?> FindByConditionAsync(Expression<Func<T, bool>> condition);
        Task AddAsync(T entity);
        Task ModifiedAsync(T entity);
        Task RemoveAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> condition);
        Task<int> CountAsync(Expression<Func<T, bool>> condition = null!);
    }
}