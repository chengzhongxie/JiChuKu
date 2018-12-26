using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 失信被执行人
    /// </summary>
    public class ZDishonestExecutorDto:FatherClassDto
    {
        /// <summary>
        /// 执行案号
        /// </summary>
        public string ZEnforcementNumber { get; set; }
        /// <summary>
        /// 执行法院
        /// </summary>
        public string ZCourtOfExecution { get; set; }
        /// <summary>
        /// 立案日期
        /// </summary>
        public string ZFilingDate { get; set; }
        /// <summary>
        /// 案件状态
        /// </summary>
        public string ZCaseStatus { get; set; }
        /// <summary>
        /// 执行依据文号
        /// </summary>
        public string ZExecutionNumber { get; set; }
        /// <summary>
        /// 执行案由
        /// </summary>
        public string ZEnforcementCase { get; set; }
        /// <summary>
        /// 法律文书确定的义务
        /// </summary>
        public string ZDefiniteObligations { get; set; }
        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        public string ZPerformance { get; set; }
        /// <summary>
        /// 被执行人失信情形
        /// </summary>
        public string BreachOfFaith { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public string ReleaseTime { get; set; }
    }
}
