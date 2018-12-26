using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 行政检查F集合
    /// </summary>
    public class FAdministrativeExamination : FatherClass
    {
        /// <summary>
        /// 行政检查结果文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 检查事由
        /// </summary>
        public string FInspectionReason { get; set; }
        /// <summary>
        /// 检查依据
        /// </summary>
        public string FInspectionBasis { get; set; }
        /// <summary>
        /// 检查结果
        /// </summary>
        public string FExaminationResult { get; set; }
        /// <summary>
        /// 检查机关
        /// </summary>
        public string FInspectionOrgan { get; set; }
        /// <summary>
        /// 检查日期
        /// </summary>
        public string FInspectionDate { get; set; }
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
    public class FAdministrativeExaminationConfiguration : IEntityTypeConfiguration<FAdministrativeExamination>
    {
        public void Configure(EntityTypeBuilder<FAdministrativeExamination> builder)
        {
            builder.Property(x => x.FBookNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FInspectionReason).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FInspectionBasis).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FExaminationResult).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FInspectionOrgan).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FInspectionDate).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCurrentState).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FLocalCoding).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.FLegalPerson).WithMany(x => x.FAdministrativeExaminations).HasForeignKey(x => x.FLegalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
