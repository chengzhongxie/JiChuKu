using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 日志
    /// </summary>
    public class SysLogDto
    {
        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 模块
        /// </summary>
        public string MenuId { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatePerson { get; set; }
        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 编辑人
        /// </summary>
        public string UpdatePerson { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Version { get; set; }
    }
}
