using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
