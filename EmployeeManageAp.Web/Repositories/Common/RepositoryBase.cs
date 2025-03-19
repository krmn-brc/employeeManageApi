using System.Linq.Expressions;
using EmployeeManageAp.Web.Entities.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManageAp.Web.Repositories.Common
{
    public class RepositoryBase<TEntity>:IRepositoryBase<TEntity>
    where TEntity:class, IEntityBase, new()
    {
        protected readonly RepositoryContext _context;
        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }

        private DbSet<TEntity> Table => _context.Set<TEntity>();
        public async Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> condition = null!)
        {
           return condition == null ? await Table.ToListAsync() : await Table.Where(condition).ToListAsync() ;
        }
        public async Task<TEntity?> FindByConditionAsync(Expression<Func<TEntity, bool>> condition)
        {
            return await Table.SingleOrDefaultAsync(condition);
        }
        public async Task AddAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
        }
        public async Task ModifiedAsync(TEntity entity)
        {
            await Task.Run(() => Table.Update(entity));
        }
        public async Task RemoveAsync(TEntity entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> condition)
        {
            return await Table.AnyAsync(condition);
        }
        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> condition = null!)
        {
            return await Table.CountAsync(condition);
        }
    }
}