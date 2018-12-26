using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 行政处罚
    /// </summary>
    public class ZAdministrativeSanction : FatherClass
    {
        /// <summary>
        /// 行政许可决定书文号
        /// </summary>
        public string ZBookNumber { get; set; }
        /// <summary>
        /// 案件名称
        /// </summary>
        public string ZNameOfCase { get; set; }
        /// <summary>
        /// 处罚类别
        /// </summary>
        public string ZPunishmentCategory { get; set; }
        /// <summary>
        /// 处罚事由
        /// </summary>
        public string ZPunishmentCause { get; set; }
        /// <summary>
        /// 处罚依据
        /// </summary>
        public string ZPunishmentBasis { get; set; }
        /// <summary>
        /// 处罚生效期
        /// </summary>
        public string ZEffectivePeriod { get; set; }
        /// <summary>
        /// 处罚截止期
        /// </summary>
        public string ZDeadline { get; set; }
        /// <summary>
        /// 处罚机关
        /// </summary>
        public string ZPunishmentOrgan { get; set; }
        /// <summary>
        /// 处罚结果
        /// </summary>
        public string ZPenaltyResult { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string ZCurrentState { get; set; }
        /// <summary>
        /// 地方编码
        /// </summary>
        public string ZLocalCoding { get; set; }
        /// <summary>
        /// 自然人基本数据id
        /// </summary>
        public string ZNaturalPersonID { get; set; }
        /// <summary>
        /// 自然人基本数据
        /// </summary>
        public ZNaturalPerson ZNaturalPerson { get; set; }
    }
    public class ZAdministrativeSanctionConfiguration : IEntityTypeConfiguration<ZAdministrativeSanction>
    {
        public void Configure(EntityTypeBuilder<ZAdministrativeSanction> builder)
        {
            builder.Property(x => x.ZBookNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZNameOfCase).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZPunishmentCategory).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZPunishmentCause).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZEffectivePeriod).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZDeadline).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZPunishmentBasis).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZCurrentState).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZLocalCoding).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZPunishmentOrgan).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZPenaltyResult).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.ZNaturalPerson).WithMany(x => x.ZAdministrativeSanctions).HasForeignKey(x => x.ZNaturalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
