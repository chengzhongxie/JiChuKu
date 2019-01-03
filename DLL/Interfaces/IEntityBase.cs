using System;

namespace DAL.Interfaces
{
    public interface IEntityBase
    {
        /// <summary>
        /// id
        /// </summary>
         string Id { get; set; }
        /// <summary>
        /// 数据更新时间戳
        /// </summary>
         DateTime ZUpdateTimestamp { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
         string Remarks { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
         string State { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
         DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
         string CreatePerson { get; set; }
        /// <summary>
        /// 编辑时间
        /// </summary>
         DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 编辑人
        /// </summary>
         string UpdatePerson { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
         DateTime? Version { get; set; }
    }
}
