using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 行政奖励F集合
    /// </summary>
    public class FAdministrativeRewardDto:FatherClassDto
    {
        /// <summary>
        /// 荣誉称号/获奖名称
        /// </summary>
        public string FHonoraryTitle { get; set; }
        /// <summary>
        /// 表彰（授予/评定）单位
        /// </summary>
        public string FCommendationUnit { get; set; }
        /// <summary>
        /// 表彰（授予/评定）日期
        /// </summary>
        public string FCommendationDate { get; set; }
        /// <summary>
        /// 表彰（授予/评定）文号
        /// </summary>
        public string FCommendationSymbol { get; set; }

    }
}
