using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政强制
    /// </summary>
    public class ZAdministrativeCoercionDto : FatherClassDto
    {
        /// <summary>
        /// 行政强制执行决定书文号
        /// </summary>
        public string ZBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ZEntryName { get; set; }
        /// <summary>
        /// 行政机关
        /// </summary>
        public string ZAdministrativeOrgan { get; set; }
        /// <summary>
        /// 强制内容
        /// </summary>
        public string ZMandatoryContent { get; set; }
        /// <summary>
        /// 执行日期
        /// </summary>
        public string ZExecutionDate { get; set; }
    }
}
