using DAL.Entities;
using DAL.Model;
using IBLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;


namespace BLL
{
    public class FLegalPersonRepository : BaseRepository<FLegalPerson>, IFLegalPersonRepository, IDisposable
    {
        private readonly MyContext _myContext;
        public FLegalPersonRepository(MyContext myContext) : base(myContext)
        {
            _myContext = myContext;
        }

        /// <summary>
        /// 通过主键id，获取行政强制F---查看详细，首次编辑
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>法人基本数据</returns>
        public FLegalPerson GetById(string id, bool isData = false)
        {
            if (isData)
            {
                _myContext.FLegalPerson.Include(x => x.FAdministrativeCoercions).FirstOrDefault(x => x.Id == id);
                _myContext.FLegalPerson.Include(x => x.FAdministrativeExaminations).FirstOrDefault(x => x.Id == id);
                _myContext.FLegalPerson.Include(x => x.FAdministrativeLicensings).FirstOrDefault(x => x.Id == id);
                _myContext.FLegalPerson.Include(x => x.FOtherCommendations).FirstOrDefault(x => x.Id == id);
                _myContext.FLegalPerson.Include(x => x.FAdministrativeSanctions).FirstOrDefault(x => x.Id == id);
                _myContext.FLegalPerson.Include(x => x.FAdministrativeRewards).FirstOrDefault(x => x.Id == id);
                _myContext.FLegalPerson.Include(x => x.FDishonestExecutors).FirstOrDefault(x => x.Id == id);
                _myContext.FLegalPerson.Include(x => x.FOtherPenaltiess).FirstOrDefault(x => x.Id == id);
                //return _myContext.FLegalPerson.SingleOrDefault(s => s.Id.ToString() == id);
            }
            return _myContext.FLegalPerson.Find(id);
        }

        //public IQueryable<FLegalPerson> GetData(int pageSize, int pageIndex, bool isAsc)
        //{
        //    Expression<Func<FLegalPerson, bool>> filter = u => true;
        //    Expression<Func<FLegalPerson>> filter2 = u => true;
        //    if (!string.IsNullOrEmpty(username))
        //    {
        //        filter = filter.And(c => c.UserName.Contains(username));
        //    }
        //    if (!string.IsNullOrEmpty(phone))
        //    {
        //        filter = filter.And(c => c.PhoneNumber.Contains(phone));
        //    }
        //    if (!string.IsNullOrEmpty(email))
        //    {
        //        filter = filter.And(c => c.Email.Contains(email));
        //    }
        //    base.LoadPageItems<FLegalPerson>(pageSize, pageIndex, out int total, filter, x => x.Id, isAsc);
        //}


        /// <summary>
        /// 查询的数据
        /// </summary>
        /// <param name="SysEntities">数据访问的上下文</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="listQuery">额外的参数</param>
        /// <returns></returns>      
        //public IQueryable<FAdministrativeCoercion> GetData(string order, string sort, string search, params object[] listQuery)
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
        //      ((System.Data.Entity.Core.Objects.Infrastructure.IObjectContextAdapter)_myContext).ObjectContext
        //             .Where(string.IsNullOrEmpty(where) ? "true" : where)
        //             .OrderBy("it.[" + sort.GetString() + "] " + order.GetString())
        //             .AsQueryable();

        //}


        /// <summary>
        /// 删除一个行政强制F
        /// </summary>
        /// <param name="db">实体数据</param>
        /// <param name="id">一条法人基本数据的主键</param>
        public int Delete(string id)
        {
            FLegalPerson deleteItem = GetById(id);
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
            IQueryable<FLegalPerson> collection = from f in _myContext.FLegalPerson
                                                  where deleteCollection.Contains(f.Id.ToString())
                                                  select f;
            return base.Delete(collection);
        }
        public void Dispose()
        {
        }
    }
}
