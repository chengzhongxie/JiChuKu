using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政奖励
    /// </summary>
    public class ZAdministrativeRewardDto : FatherClassDto
    {
        /// <summary>
        /// 荣誉称号/获奖名称
        /// </summary>
        public string ZHonoraryTitle { get; set; }
        /// <summary>
        /// 表彰（授予/评定）单位
        /// </summary>
        public string ZCommendationUnit { get; set; }
        /// <summary>
        /// 表彰（授予/评定）日期
        /// </summary>
        public string ZCommendationDate { get; set; }
        /// <summary>
        /// 表彰（授予/评定）文号
        /// </summary>
        public string ZCommendationSymbol { get; set; }
    }
}
