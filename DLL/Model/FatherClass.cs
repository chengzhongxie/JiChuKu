using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    public class FatherClass
    {
        public FatherClass()
        {
            Id = Guid.NewGuid().ToString("N");
            CreateTime = DateTime.Now;
            Version = DateTime.Now;
        }

        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 编辑人
        /// </summary>
        public string UpdatePerson { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime? Version { get; set; }
    }
    public class FatherClassConfiguration : IEntityTypeConfiguration<FatherClass>
    {
        public void Configure(EntityTypeBuilder<FatherClass> builder)
        {
            builder.Property(x => x.Id).HasMaxLength(36);
            builder.Property(x => x.Remarks).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.State).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.CreatePerson).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.UpdatePerson).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.UpdateTime).IsRequired(false);
            builder.Property(x => x.Version).IsRowVersion();
        }
    }
}
