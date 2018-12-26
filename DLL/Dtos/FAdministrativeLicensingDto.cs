using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政许可F集合
    /// </summary>
    public class FAdministrativeLicensingDto:FatherClassDto
    {
        /// <summary>
        /// 行政许可决定书文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string FEntryName { get; set; }
        /// <summary>
        /// 审批类别
        /// </summary>
        public string FApprovalCategory { get; set; }
        /// <summary>
        /// 许可内容
        /// </summary>
        public string FPermissionContent { get; set; }
        /// <summary>
        /// 许可生效期
        /// </summary>
        public string FEffectivePeriod { get; set; }
        /// <summary>
        /// 许可截止期
        /// </summary>
        public string FDeadline { get; set; }
        /// <summary>
        /// 许可机关
        /// </summary>
        public string FLicensingAuthority { get; set; }
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
