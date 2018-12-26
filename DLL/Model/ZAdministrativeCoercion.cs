using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 行政强制
    /// </summary>
    public class ZAdministrativeCoercion : FatherClass
    {
        /// <summary>
        /// 行政强制执行决定书文号
        /// </summary>
        public string ZBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ZEntryName { get; set; }
        /// <summary>
        /// 行政机关
        /// </summary>
        public string ZAdministrativeOrgan { get; set; }
        /// <summary>
        /// 强制内容
        /// </summary>
        public string ZMandatoryContent { get; set; }
        /// <summary>
        /// 执行日期
        /// </summary>
        public string ZExecutionDate { get; set; }
        /// <summary>
        /// 自然人基本数据id
        /// </summary>
        public string ZNaturalPersonID { get; set; }
        /// <summary>
        /// 自然人基本数据
        /// </summary>
        public ZNaturalPerson ZNaturalPerson { get; set; }
    }

    public class ZAdministrativeCoercionConfiguration : IEntityTypeConfiguration<ZAdministrativeCoercion>
    {
        public void Configure(EntityTypeBuilder<ZAdministrativeCoercion> builder)
        {
            builder.Property(x => x.ZBookNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZEntryName).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZAdministrativeOrgan).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZMandatoryContent).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZExecutionDate).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.ZNaturalPerson).WithMany(x => x.ZAdministrativeCoercions).HasForeignKey(x => x.ZNaturalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
