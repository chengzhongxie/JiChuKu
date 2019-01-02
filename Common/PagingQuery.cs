using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Common
{
  public  class PagingQuery<T> where T:class
    {
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <typeparam name="TKey">排序类型</typeparam>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页大小</param>
        /// <param name="isAsc">是否升序排列</param>
        /// <param name="predicate">条件表达式</param>
        /// <param name="keySelector">排序表达式</param>
        /// <returns></returns>
        public virtual IPage<T> Page<TKey>(int pageIndex, int pageSize, Expression<Func<T, bool>> predicate, bool isAsc,
            Expression<Func<T, TKey>> keySelector)
        {
            if (pageIndex <= 0 && pageSize <= 0)
            {
                throw new Exception("pageIndex或pageSize不能小于等于0！");
            }
            IPage<T> page = new Page<T>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            int skip = (pageIndex - 1) * pageSize;
            if (predicate == null)
            {
                FutureCount fcount = this.dbSet.FutureCount();
                FutureQuery<T> futureQuery = isAsc
                    ? this.dbSet.OrderBy(keySelector).Skip(skip).Take(pageSize).Future()
                    : this.dbSet.OrderByDescending(keySelector).Skip(skip).Take(pageSize).Future();
                page.TotalItems = fcount.Value;
                page.Items = futureQuery.ToList();
                page.TotalPages = page.TotalItems / pageSize;
                if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
            }
            else
            {
                var queryable = this.dbSet.Where(predicate);
                FutureCount fcount = queryable.FutureCount();
                FutureQuery<T> futureQuery = isAsc
                    ? queryable.OrderBy(keySelector).Skip(skip).Take(pageSize).Future()
                    : queryable.OrderByDescending(keySelector).Skip(skip).Take(pageSize).Future();
                page.TotalItems = fcount.Value;
                page.Items = futureQuery.ToList();
                page.TotalPages = page.TotalItems / pageSize;
                if ((page.TotalItems % pageSize) != 0) page.TotalPages++;
            }
            return page;
        }
    }
    /// <summary>
    /// 分页实体
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public class Page<T> : IPage<T>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages { get; set; }
        /// <summary>
        /// 查询集合总个数
        /// </summary>
        public int TotalItems { get; set; }
        /// <summary>
        /// 每页项数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 查询集合
        /// </summary>
        public IList<T> Items { get; set; }
    }

    /// <summary>
    /// 分页实体接口
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public interface IPage<T>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        int PageIndex { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        int TotalPages { get; set; }
        /// <summary>
        /// 查询集合总个数
        /// </summary>
        int TotalItems { get; set; }
        /// <summary>
        /// 每页项数
        /// </summary>
        int PageSize { get; set; }
        /// <summary>
        /// 查询集合
        /// </summary>
        IList<T> Items { get; set; }
    }
}
