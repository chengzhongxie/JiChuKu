using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.Models
{
    public class FatherClassTest
    {
        public FatherClassTest()
        {
            Id = Guid.NewGuid().ToString("N");
            CreateTime = DateTime.Now;
        }

        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 数据更新时间戳
        /// </summary>
        public DateTime ZUpdateTimestamp { get; set; }
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
