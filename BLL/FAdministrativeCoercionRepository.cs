using DAL.Entities;
using DAL.Model;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 行政强制F实现
    /// </summary>
    public partial class FAdministrativeCoercionRepository : BaseRepository<FAdministrativeCoercion>, IFAdministrativeCoercionRepository, IDisposable
    {
        private readonly MyContext _myContext;
        public FAdministrativeCoercionRepository(MyContext myContext) : base(myContext)
        {
            _myContext = myContext;
        }
        /// <summary>
        /// 查询的数据
        /// </summary>
        /// <param name="SysEntities">数据访问的上下文</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="listQuery">额外的参数</param>
        /// <returns></returns>      
        //public IQueryable<FAdministrativeCoercion> GetData(MyContext db, string order, string sort, string search, params object[] listQuery)
        //{
        //    string where = string.Empty;
        //    int flagWhere = 0;

        //    Dictionary<string, string> queryDic = ValueConvert.StringToDictionary(search.GetString());
        //    if (queryDic != null && queryDic.Count > 0)
        //    {
        //        foreach (var item in queryDic)
        //        {
        //            if (flagWhere != 0)
        //            {
        //                where += " and ";
        //            }
        //            flagWhere++;

        //            if (!string.IsNullOrWhiteSpace(item.Key) && !string.IsNullOrWhiteSpace(item.Value) && item.Key.Contains(Start_Time)) //开始时间
        //            {
        //                where += "it.[" + item.Key.Remove(item.Key.IndexOf(Start_Time)) + "] >=  CAST('" + item.Value + "' as   System.DateTime)";
        //                continue;
        //            }
        //            if (!string.IsNullOrWhiteSpace(item.Key) && !string.IsNullOrWhiteSpace(item.Value) && item.Key.Contains(End_Time)) //结束时间+1
        //            {
        //                where += "it.[" + item.Key.Remove(item.Key.IndexOf(End_Time)) + "] <  CAST('" + Convert.ToDateTime(item.Value).AddDays(1) + "' as   System.DateTime)";
        //                continue;
        //            }
        //            if (!string.IsNullOrWhiteSpace(item.Key) && !string.IsNullOrWhiteSpace(item.Value) && item.Key.Contains(Start_Int)) //开始数值
        //            {
        //                where += "it.[" + item.Key.Remove(item.Key.IndexOf(Start_Int)) + "] >= " + item.Value.GetInt();
        //                continue;
        //            }
        //            if (!string.IsNullOrWhiteSpace(item.Key) && !string.IsNullOrWhiteSpace(item.Value) && item.Key.Contains(End_Int)) //结束数值
        //            {
        //                where += "it.[" + item.Key.Remove(item.Key.IndexOf(End_Int)) + "] <= " + item.Value.GetInt();
        //                continue;
        //            }

        //            if (!string.IsNullOrWhiteSpace(item.Key) && !string.IsNullOrWhiteSpace(item.Value) && item.Key.Contains(DDL_Int)) //精确查询数值
        //            {
        //                where += "it.[" + item.Key.Remove(item.Key.IndexOf(DDL_Int)) + "] =" + item.Value;
        //                continue;
        //            }
        //            if (!string.IsNullOrWhiteSpace(item.Key) && !string.IsNullOrWhiteSpace(item.Value) && item.Key.Contains(DDL_String)) //精确查询字符串
        //            {
        //                where += "it.[" + item.Key.Remove(item.Key.IndexOf(DDL_String)) + "] = '" + item.Value + "'";
        //                continue;
        //            }
        //            where += "it.[" + item.Key + "] like '%" + item.Value + "%'";//模糊查询
        //        }
        //    }
        //    return   
        //      (db.ChangeTracker).ObjectContext
        //             .Where(string.IsNullOrEmpty(where) ? "true" : where)
        //             .OrderBy("it.[" + sort.GetString() + "] " + order.GetString())
        //             .AsQueryable();

        //}


        /// <summary>
        /// 通过主键id，获取行政强制F---查看详细，首次编辑
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>项目经验</returns>
        public FAdministrativeCoercion GetById(string id)
        {
            return _myContext.FAdministrativeCoercion.SingleOrDefault(s => s.Id.ToString() == id);
        }

        /// <summary>
        /// 删除一个行政强制F
        /// </summary>
        /// <param name="db">实体数据</param>
        /// <param name="id">一条项目经验的主键</param>
        public int Delete(string id)
        {
            FAdministrativeCoercion deleteItem = GetById(id);
            if (deleteItem != null)
            {
                return base.Delete(deleteItem);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 删除对象集合
        /// </summary>
        /// <param name="db">实体数据</param>
        /// <param name="deleteCollection">主键的集合</param>
        public int Delete(string[] deleteCollection)
        {
            //数据库设置级联关系，自动删除子表的内容   
            IQueryable<FAdministrativeCoercion> collection = from f in _myContext.FAdministrativeCoercion
                                                             where deleteCollection.Contains(f.Id.ToString())
                                                             select f;
            return base.Delete(collection);
        }
        public void Dispose()
        {
        }


    }
}
