using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IBLL
{
    public interface IFLegalPersonRepository
    {
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        IQueryable<FLegalPerson> GetAll();
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
        IQueryable<FLegalPerson> LoadPageItems<Tkey>(int pageSize, int pageIndex, out int total, Expression<Func<FLegalPerson, bool>> whereLambda, Func<FLegalPerson, Tkey> orderbyLambda, bool isAsc);
        /// <summary>
        /// 根据id查询数据
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="isData">是否带出关联数据</param>
        /// <returns></returns>
        FLegalPerson GetById(string id, bool isData);
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        int Create(FLegalPerson person);

        /// <summary>
        /// 根据id删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(string id);
    }
}
