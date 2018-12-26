using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 行政强制F集合
    /// </summary>
    public class FAdministrativeCoercion : FatherClass
    {
        /// <summary>
        /// 行政强制执行决定书文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string FEntryName { get; set; }
        /// <summary>
        /// 行政机关
        /// </summary>
        public string FAdministrativeOrgan { get; set; }
        /// <summary>
        /// 强制内容
        /// </summary>
        public string FMandatoryContent { get; set; }
        /// <summary>
        /// 执行日期
        /// </summary>
        public string FExecutionDate { get; set; }
        /// <summary>
        /// 法人基本数据id
        /// </summary>
        public string FLegalPersonID { get; set; }
        /// <summary>
        /// 法人基本数据
        /// </summary>
        public FLegalPerson FLegalPerson { get; set; }
    }
    public class FAdministrativeCoercionConfiguration : IEntityTypeConfiguration<FAdministrativeCoercion>
    {
        public void Configure(EntityTypeBuilder<FAdministrativeCoercion> builder)
        {
            builder.Property(x => x.FBookNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FEntryName).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FAdministrativeOrgan).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FMandatoryContent).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FExecutionDate).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.FLegalPerson).WithMany(x => x.FAdministrativeCoercions).HasForeignKey(x => x.FLegalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
