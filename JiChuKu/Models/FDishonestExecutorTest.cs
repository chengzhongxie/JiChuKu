using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JiChuKu.Models
{
    /// <summary>
    /// 失信被执行人F集合
    /// </summary>
    public class FDishonestExecutorTest : FatherClassTest
    {
        /// <summary>
        /// 执行案号
        /// </summary>
        public string FEnforcementNumber { get; set; }
        /// <summary>
        /// 执行法院
        /// </summary>
        public string FCourtOfExecution { get; set; }
        /// <summary>
        /// 立案日期
        /// </summary>
        public string FFilingDate { get; set; }
        /// <summary>
        /// 案件状态
        /// </summary>
        public string FCaseStatus { get; set; }
        /// <summary>
        /// 执行依据文号
        /// </summary>
        public string FExecutionNumber { get; set; }
        /// <summary>
        /// 执行案由
        /// </summary>
        public string FEnforcementCase { get; set; }
        /// <summary>
        /// 法律文书确定的义务
        /// </summary>
        public string FDefiniteObligations { get; set; }
        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        public string FPerformance { get; set; }
        /// <summary>
        /// 被执行人失信情形
        /// </summary>
        public string BreachOfFaith { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public string ReleaseTime { get; set; }
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
