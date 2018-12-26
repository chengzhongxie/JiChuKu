using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JiChuKu.Models
{
    /// <summary>
    /// 行政奖励F集合
    /// </summary>
    public class FAdministrativeRewardTest : FatherClassTest
    {
        /// <summary>
        /// 荣誉称号/获奖名称
        /// </summary>
        public string FHonoraryTitle { get; set; }
        /// <summary>
        /// 表彰（授予/评定）单位
        /// </summary>
        public string FCommendationUnit { get; set; }
        /// <summary>
        /// 表彰（授予/评定）日期
        /// </summary>
        public string FCommendationDate { get; set; }
        /// <summary>
        /// 表彰（授予/评定）文号
        /// </summary>
        public string FCommendationSymbol { get; set; }
        /// <summary>
        /// 法人基本数据id
        /// </summary>
        public string FLegalPersonID { get; set; }
        /// <summary>
        /// 法人基本数据
        /// </summary>
        public FLegalPersonTest FLegalPerson { get; set; }
    }
}
