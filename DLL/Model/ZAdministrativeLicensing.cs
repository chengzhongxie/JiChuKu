using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 行政许可
    /// </summary>
    public class ZAdministrativeLicensing : FatherClass
    {
        /// <summary>
        /// 行政许可决定书文号
        /// </summary>
        public string ZBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ZEntryName { get; set; }
        /// <summary>
        /// 审批类别
        /// </summary>
        public string ZApprovalCategory { get; set; }
        /// <summary>
        /// 许可内容
        /// </summary>
        public string ZPermissionContent { get; set; }
        /// <summary>
        /// 许可生效期
        /// </summary>
        public string ZEffectivePeriod { get; set; }
        /// <summary>
        /// 许可截止期
        /// </summary>
        public string ZDeadline { get; set; }
        /// <summary>
        /// 许可机关
        /// </summary>
        public string ZLicensingAuthority { get; set; }
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
    public class ZAdministrativeLicensingConfiguration : IEntityTypeConfiguration<ZAdministrativeLicensing>
    {
        public void Configure(EntityTypeBuilder<ZAdministrativeLicensing> builder)
        {
            builder.Property(x => x.ZBookNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZEntryName).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZApprovalCategory).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZPermissionContent).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZEffectivePeriod).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZDeadline).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZLicensingAuthority).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZCurrentState).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZLocalCoding).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.ZNaturalPerson).WithMany(x => x.ZAdministrativeLicensings).HasForeignKey(x => x.ZNaturalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
