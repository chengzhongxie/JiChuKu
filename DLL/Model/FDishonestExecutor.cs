using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 失信被执行人F集合
    /// </summary>
    public class FDishonestExecutor : FatherClass
    {
        /// <summary>
        /// 执行案号
        /// </summary>
        public string FEnforcementNumber { get; set; }
        /// <summary>
        /// 执行法院
        /// </summary>
        public string FCourtOfExecution { get; set; }
        /// <summary>
        /// 立案日期
        /// </summary>
        public string FFilingDate { get; set; }
        /// <summary>
        /// 案件状态
        /// </summary>
        public string FCaseStatus { get; set; }
        /// <summary>
        /// 执行依据文号
        /// </summary>
        public string FExecutionNumber { get; set; }
        /// <summary>
        /// 执行案由
        /// </summary>
        public string FEnforcementCase { get; set; }
        /// <summary>
        /// 法律文书确定的义务
        /// </summary>
        public string FDefiniteObligations { get; set; }
        /// <summary>
        /// 被执行人履行情况
        /// </summary>
        public string FPerformance { get; set; }
        /// <summary>
        /// 被执行人失信情形
        /// </summary>
        public string BreachOfFaith { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public string ReleaseTime { get; set; }
        /// <summary>
        /// 法人基本数据id
        /// </summary>
        public string FLegalPersonID { get; set; }
        /// <summary>
        /// 法人基本数据
        /// </summary>
        public FLegalPerson FLegalPerson { get; set; }
    }
    public class FDishonestExecutorConfiguration : IEntityTypeConfiguration<FDishonestExecutor>
    {
        public void Configure(EntityTypeBuilder<FDishonestExecutor> builder)
        {
            builder.Property(x => x.FEnforcementNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCourtOfExecution).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FFilingDate).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCaseStatus).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FExecutionNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FEnforcementCase).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FDefiniteObligations).IsRequired(false).HasColumnType("ntext"); 
            builder.Property(x => x.FPerformance).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.BreachOfFaith).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ReleaseTime).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.FLegalPerson).WithMany(x => x.FDishonestExecutors).HasForeignKey(x => x.FLegalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
