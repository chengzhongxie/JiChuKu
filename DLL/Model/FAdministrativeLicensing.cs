using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 行政许可F集合
    /// </summary>
    public class FAdministrativeLicensing : FatherClass
    {
        /// <summary>
        /// 行政许可决定书文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string FEntryName { get; set; }
        /// <summary>
        /// 审批类别
        /// </summary>
        public string FApprovalCategory { get; set; }
        /// <summary>
        /// 许可内容
        /// </summary>
        public string FPermissionContent { get; set; }
        /// <summary>
        /// 许可生效期
        /// </summary>
        public string FEffectivePeriod { get; set; }
        /// <summary>
        /// 许可截止期
        /// </summary>
        public string FDeadline { get; set; }
        /// <summary>
        /// 许可机关
        /// </summary>
        public string FLicensingAuthority { get; set; }
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
    public class FAdministrativeLicensingConfiguration : IEntityTypeConfiguration<FAdministrativeLicensing>
    {
        public void Configure(EntityTypeBuilder<FAdministrativeLicensing> builder)
        {
            builder.Property(x => x.FBookNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FEntryName).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FApprovalCategory).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FPermissionContent).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FEffectivePeriod).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FDeadline).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FLicensingAuthority).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCurrentState).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FLocalCoding).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.FLegalPerson).WithMany(x => x.FAdministrativeLicensings).HasForeignKey(x => x.FLegalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
