using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政许可
    /// </summary>
    public class ZAdministrativeLicensingDto : FatherClassDto
    {
        /// <summary>
        /// 行政许可决定书文号
        /// </summary>
        public string ZBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ZEntryName { get; set; }
        /// <summary>
        /// 审批类别
        /// </summary>
        public string ZApprovalCategory { get; set; }
        /// <summary>
        /// 许可内容
        /// </summary>
        public string ZPermissionContent { get; set; }
        /// <summary>
        /// 许可生效期
        /// </summary>
        public string ZEffectivePeriod { get; set; }
        /// <summary>
        /// 许可截止期
        /// </summary>
        public string ZDeadline { get; set; }
        /// <summary>
        /// 许可机关
        /// </summary>
        public string ZLicensingAuthority { get; set; }
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
