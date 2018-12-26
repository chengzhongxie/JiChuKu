using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政处罚
    /// </summary>
    public class ZAdministrativeSanctionDto : FatherClassDto
    {
        /// <summary>
        /// 行政许可决定书文号
        /// </summary>
        public string ZBookNumber { get; set; }
        /// <summary>
        /// 案件名称
        /// </summary>
        public string ZNameOfCase { get; set; }
        /// <summary>
        /// 处罚类别
        /// </summary>
        public string ZPunishmentCategory { get; set; }
        /// <summary>
        /// 处罚事由
        /// </summary>
        public string ZPunishmentCause { get; set; }
        /// <summary>
        /// 处罚依据
        /// </summary>
        public string ZPunishmentBasis { get; set; }
        /// <summary>
        /// 处罚生效期
        /// </summary>
        public string ZEffectivePeriod { get; set; }
        /// <summary>
        /// 处罚截止期
        /// </summary>
        public string ZDeadline { get; set; }
        /// <summary>
        /// 处罚机关
        /// </summary>
        public string ZPunishmentOrgan { get; set; }
        /// <summary>
        /// 处罚结果
        /// </summary>
        public string ZPenaltyResult { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string ZCurrentState { get; set; }
        /// <summary>
        /// 地方编码
        /// </summary>
        public string ZLocalCoding { get; set; }
    }
}
