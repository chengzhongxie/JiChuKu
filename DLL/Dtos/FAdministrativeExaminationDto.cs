using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政检查F集合
    /// </summary>
    public class FAdministrativeExaminationDto : FatherClassDto
    {
        /// <summary>
        /// 行政检查结果文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 检查事由
        /// </summary>
        public string FInspectionReason { get; set; }
        /// <summary>
        /// 检查依据
        /// </summary>
        public string FInspectionBasis { get; set; }
        /// <summary>
        /// 检查结果
        /// </summary>
        public string FExaminationResult { get; set; }
        /// <summary>
        /// 检查机关
        /// </summary>
        public string FInspectionOrgan { get; set; }
        /// <summary>
        /// 检查日期
        /// </summary>
        public string FInspectionDate { get; set; }
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
