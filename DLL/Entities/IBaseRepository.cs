using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Entities
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns>集合</returns>
        IQueryable<T> GetAll();
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
        IQueryable<T> LoadPageItems<Tkey>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, Tkey>> orderbyLambda, bool isAsc);
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="entity">一个对象</param>
        /// <returns></returns>
        int Create(T entity);
        /// <summary>
        /// 创建对象集合
        /// </summary>
        /// <param name="entitys">对象集合</param>
        int Create(IQueryable<T> entitys);
        /// <summary>
        /// 编辑一个对象
        /// </summary>
        /// <param name="entity">将要编辑的一个对象</param>
        /// <param name="isAttach">是否附加到数据库上下文</param>
        T Edit(T entity, bool isAttach = true);
        /// <summary>
        /// 编辑对象集合
        /// <param name="entitys">对象集合</param>
        void Edit(IQueryable<T> entitys);
        /// <summary>
        /// 删除一个项目经验
        /// </summary>
        /// <param name="id">一条项目经验的主键</param>
        int Delete(T entity);
        /// <summary>
        /// 删除对象集合
        /// </summary>
        /// <param name="entitys">对象集合</param>
        int Delete(IQueryable<T> entitys);
        /// <summary>
        /// 提交保存，持久化到数据库
        /// </summary>
        /// <returns>受影响行数</returns>
        int Save();
    }
}
