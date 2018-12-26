using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLL
{
    /// <summary>
    /// 行政强制F接口
    /// </summary>
    public interface IFAdministrativeCoercionRepository
    {
        /// <summary>
        /// 查询的数据
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        //IEnumerable<FAdministrativeCoercion> GetByParam();
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        IQueryable<FAdministrativeCoercion> GetAll();
        /// <summary>
        /// 根据id获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FAdministrativeCoercion GetById(string id);
    }
}
