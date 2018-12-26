using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政强制F集合
    /// </summary>
    public class FAdministrativeCoercionDto : FatherClassDto
    {
        /// <summary>
        /// 行政强制执行决定书文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string FEntryName { get; set; }
        /// <summary>
        /// 行政机关
        /// </summary>
        public string FAdministrativeOrgan { get; set; }
        /// <summary>
        /// 强制内容
        /// </summary>
        public string FMandatoryContent { get; set; }
        /// <summary>
        /// 执行日期
        /// </summary>
        public string FExecutionDate { get; set; }
    }
}
