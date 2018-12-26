using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 异常处理
    /// </summary>
    public class SysException
    {
        public SysException()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            Version = DateTime.Now;
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string LeiXing { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public string Result { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int? Sort { get; set; }
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
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 编辑人
        /// </summary>
        public string UpdatePerson { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Version { get; set; }
    }
    public class SysExceptionConfiguration : IEntityTypeConfiguration<SysException>
    {
        public void Configure(EntityTypeBuilder<SysException> builder)
        {
            builder.Property(x => x.Id).HasMaxLength(36);
            builder.Property(x => x.Message).IsRequired(false).HasMaxLength(2000);
            builder.Property(x => x.Result).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.LeiXing).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.Remarks).IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.State).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.CreatePerson).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.UpdatePerson).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.Version).IsRowVersion();
        }
    }
}
