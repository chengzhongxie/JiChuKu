using DAL.Bases;
using DAL.Entities;
using DAL.Extensions;
using DAL.IRepositories;
using DAL.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EfEnhancedRepository<T> : EfRepository<T>, IEnhancedRepository<T> where T : EntityBase
    {
        public EfEnhancedRepository(MyContext context): base(context)
        {
        }

        public async Task<PaginatedList<T>> GetPaginatedAsync(PaginationBase parameters, PropertyMapping propertyMapping)
        {
            var collectionBeforePaging = Context.Set<T>().ApplySort(parameters.OrderBy, propertyMapping);
            parameters.Count = await collectionBeforePaging.CountAsync();
            var items = await collectionBeforePaging.Skip(parameters.PageIndex * parameters.PageSize).Take(parameters.PageSize).ToListAsync();
            var result = new PaginatedList<T>(parameters, items);
            return result;
        }

        public async Task<PaginatedList<T>> GetPaginatedAsync(PaginationBase parameters, PropertyMapping propertyMapping, Expression<Func<T, bool>> criteria) 
        {
            var collectionBeforePaging = Context.Set<T>().Where(criteria).ApplySort(parameters.OrderBy, propertyMapping);
            parameters.Count = await collectionBeforePaging.CountAsync();
            var items = await collectionBeforePaging.Skip(parameters.PageIndex * parameters.PageSize).Take(parameters.PageSize).ToListAsync();
            var result = new PaginatedList<T>(parameters, items);
            return result;
        }

        public async Task<PaginatedList<T>> GetPaginatedAsync(PaginationBase parameters, PropertyMapping propertyMapping, Expression<Func<T, bool>> criteria, 
            params Expression<Func<T, object>>[] includes)
        {
            var collectionBeforePaging = includes
                .Aggregate(Context.Set<T>().Where(criteria).ApplySort(parameters.OrderBy, propertyMapping),
                    (current, include) => current.Include(include));
            parameters.Count = await collectionBeforePaging.CountAsync();
            var items = await collectionBeforePaging.Skip(parameters.PageIndex * parameters.PageSize).Take(parameters.PageSize).ToListAsync();
            var result = new PaginatedList<T>(parameters, items);
            return result;
        }
    }
}
