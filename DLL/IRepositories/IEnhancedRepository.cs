using DAL.Bases;
using DAL.Interfaces;
using DAL.Pagination;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IEnhancedRepository<T> : IRepository<T> where T : EntityBase
    {
        Task<PaginatedList<T>> GetPaginatedAsync(PaginationBase parameters, PropertyMapping propertyMapping);
        Task<PaginatedList<T>> GetPaginatedAsync(PaginationBase parameters, PropertyMapping propertyMapping, Expression<Func<T, bool>> criteria);
        Task<PaginatedList<T>> GetPaginatedAsync(PaginationBase parameters, PropertyMapping propertyMapping, Expression<Func<T, bool>> criteria, params Expression<Func<T, object>>[] includes);
    }
}