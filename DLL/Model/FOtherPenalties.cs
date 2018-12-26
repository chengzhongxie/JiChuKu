using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 其他处罚F集合
    /// </summary>
    public class FOtherPenalties : FatherClass
    {
        /// <summary>
        /// 案件名称
        /// </summary>
        public string FNameOfCase { get; set; }
        /// <summary>
        /// 处罚类别
        /// </summary>
        public string FPunishmentCategory { get; set; }
        /// <summary>
        /// 处罚事由
        /// </summary>
        public string FPunishmentCause { get; set; }
        /// <summary>
        /// 处罚依据
        /// </summary>
        public string FPunishmentBasis { get; set; }
        /// <summary>
        /// 处罚生效期
        /// </summary>
        public string FEffectivePeriod { get; set; }
        /// <summary>
        /// 处罚截止期
        /// </summary>
        public string FDeadline { get; set; }
        /// <summary>
        /// 处罚机关
        /// </summary>
        public string FPunishmentOrgan { get; set; }
        /// <summary>
        /// 处罚结果
        /// </summary>
        public string FPenaltyResult { get; set; }
        /// <summary>
        /// 当前状态
        /// </summary>
        public string FCurrentState { get; set; }
        /// <summary>
        /// 地方编码
        /// </summary>
        public string FLocalCoding { get; set; }
        /// <summary>
        /// 法人基本数据id
        /// </summary>
        public string FLegalPersonID { get; set; }
        /// <summary>
        /// 法人基本数据
        /// </summary>
        public FLegalPerson FLegalPerson { get; set; }
    }
    public class FOtherPenaltiesConfiguration : IEntityTypeConfiguration<FOtherPenalties>
    {
        public void Configure(EntityTypeBuilder<FOtherPenalties> builder)
        {
            builder.Property(x => x.FNameOfCase).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FPunishmentCategory).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FPunishmentCause).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FPunishmentBasis).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FEffectivePeriod).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FDeadline).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FPunishmentOrgan).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FPenaltyResult).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCurrentState).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FLocalCoding).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.FLegalPerson).WithMany(x => x.FOtherPenaltiess).HasForeignKey(x => x.FLegalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
