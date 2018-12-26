using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政处罚F集合
    /// </summary>
    public class FAdministrativeSanctionDto : FatherClassDto
    {
        /// <summary>
        /// 行政处罚决定书文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 案件名称
        /// </summary>
        public string FNameOfCase { get; set; }
        /// <summary>
        /// 处罚类别
        /// </summary>
        public string FPunishmentCategory { get; set; }
        /// <summary>
        /// 处罚事由
        /// </summary>
        public string FPunishmentCause { get; set; }
        /// <summary>
        /// 处罚依据
        /// </summary>
        public string FPunishmentBasis { get; set; }
        /// <summary>
        /// 处罚生效期
        /// </summary>
        public string FEffectivePeriod { get; set; }
        /// <summary>
        /// 处罚截止期
        /// </summary>
        public string FDeadline { get; set; }
        /// <summary>
        /// 处罚机关
        /// </summary>
        public string FPunishmentOrgan { get; set; }
        /// <summary>
        /// 处罚结果
        /// </summary>
        public string FPenaltyResult { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string FCurrentState { get; set; }
        /// <summary>
        /// 地方编码
        /// </summary>
        public string FLocalCoding { get; set; }
    }
}
