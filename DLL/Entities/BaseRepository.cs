using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Entities
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly MyContext _myContext;

        public BaseRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        /// <summary>
        /// 开始时间的标识
        /// </summary>
        public string Start_Time { get { return "Start_Time"; } }
        /// <summary>
        /// 结束时间的标识
        /// </summary>
        public string End_Time { get { return "End_Time"; } }
        /// <summary>
        /// 开始数值的标识
        /// </summary>
        public string Start_Int { get { return "Start_Int"; } }
        /// <summary>
        /// 结束数值的标识
        /// </summary>
        public string End_Int { get { return "End_Int"; } }

        public string End_String { get { return "End_String"; } }  /// <summary>
                                                                   /// 精确字符串
                                                                   /// </summary>
        public string DDL_String { get { return "DDL_String"; } }
        /// <summary>
        /// 精确数字
        /// </summary>
        public string DDL_Int { get { return "DDL_Int"; } }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns>集合</returns>
        public virtual IQueryable<T> GetAll()
        {
            return _myContext.Set<T>().AsQueryable();
        }

        /// <summary>
        /// 分页查询 + 条件查询 + 排序
        /// </summary>
        /// <typeparam name="Tkey">泛型</typeparam>
        /// <param name="pageSize">每页大小</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="total">总数量</param>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderbyLambda">排序条件</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns>IQueryable 泛型集合</returns>
        public virtual IQueryable<T> LoadPageItems<Tkey>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Func<T, Tkey> orderbyLambda, bool isAsc)
        {
            total = _myContext.Set<T>().Where(whereLambda).Count();
            if (isAsc)
            {
                var temp = _myContext.Set<T>().Where(whereLambda)
                             .OrderBy<T, Tkey>(orderbyLambda)
                             .Skip(pageSize * (pageIndex - 1))
                             .Take(pageSize);
                return temp.AsQueryable();
            }
            else
            {
                var temp = _myContext.Set<T>().Where(whereLambda)
                           .OrderByDescending<T, Tkey>(orderbyLambda)
                           .Skip(pageSize * (pageIndex - 1))
                           .Take(pageSize);
                return temp.AsQueryable();
            }
        }
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="entity">一个对象</param>
        /// <returns></returns>
        public virtual int Create(T entity)
        {
            using (_myContext)
            {
                if (entity != null)
                {
                    _myContext.Set<T>().Add(entity);
                    return this.Save();
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// 创建对象集合
        /// </summary>
        /// <param name="entitys">对象集合</param>
        public virtual int Create(IQueryable<T> entitys)
        {
            int sum = 0;
            foreach (var entity in entitys)
            {
                sum += this.Create(entity);
            }
            return sum;
        }
        /// <summary>
        /// 编辑一个对象
        /// </summary>
        /// <param name="entity">将要编辑的一个对象</param>
        /// <param name="isAttach">是否附加到数据库上下文</param>
        public virtual T Edit(T entity, bool isAttach = true)
        {
            if (isAttach)
                _myContext.Set<T>().Attach(entity);
            _myContext.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        /// <summary>
        /// 编辑对象集合
        /// </summary>
        /// <param name="entitys">对象集合</param>
        public virtual void Edit(IQueryable<T> entitys)
        {
            foreach (T entity in entitys)
            {
                this.Edit(entity);
            }
        }
        /// <summary>
        /// 删除一个对象
        /// </summary>
        /// <param name="id">一条项目经验的主键</param>
        public virtual int Delete(T entity)
        {
            using (_myContext)
            {
                if (entity != null)
                {
                    _myContext.Set<T>().Remove(entity);
                    return this.Save();
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// 删除对象集合
        /// </summary>
        /// <param name="entitys">对象集合</param>
        public virtual int Delete(IQueryable<T> entitys)
        {
            int sum = 0;
            foreach (var entity in entitys)
            {
                sum += this.Delete(entity);
            }
            return sum;
        }
        /// <summary>
        /// 提交保存，持久化到数据库
        /// </summary>
        /// <returns>受影响行数</returns>
        public int Save()
        {
            return _myContext.SaveChanges();
        }

    }
}
