using DAL.Entities;
using DAL.Model;
using IBLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
