using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 自然人基本数据
    /// </summary>
    public class ZNaturalPerson : FatherClass
    {

        /// <summary>
        /// 姓名
        /// </summary>
        public string ZName { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public string ZDocumentType { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string ZLdentificationNumber { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string ZCompany { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string ZPost { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string ZDataSources { get; set; }

        /// <summary>
        /// 行政许可Z集合
        /// </summary>
        public ICollection<ZAdministrativeLicensing> ZAdministrativeLicensings { get; set; }
        /// <summary>
        /// 行政处罚Z集合
        /// </summary>
        public ICollection<ZAdministrativeSanction> ZAdministrativeSanctions { get; set; }
        /// <summary>
        /// 行政奖励Z集合
        /// </summary>
        public ICollection<ZAdministrativeReward> ZAdministrativeRewards { get; set; }
        /// <summary>
        /// 其他处罚Z集合
        /// </summary>
        public ICollection<ZOtherPenalties> ZOtherPenaltiess { get; set; }
        /// <summary>
        /// 其他表彰Z集合
        /// </summary>
        public ICollection<ZOtherCommendation> ZOtherCommendations { get; set; }
        /// <summary>
        /// 失信被执行人Z集合
        /// </summary>
        public ICollection<ZDishonestExecutor> ZDishonestExecutors { get; set; }
        /// <summary>
        /// 行政强制Z集合
        /// </summary>
        public ICollection<ZAdministrativeCoercion> ZAdministrativeCoercions { get; set; }
    }
    public class ZNaturalPersonConfiguration : IEntityTypeConfiguration<ZNaturalPerson>
    {
        public void Configure(EntityTypeBuilder<ZNaturalPerson> builder)
        {
            builder.Property(x => x.ZName).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZDocumentType).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZLdentificationNumber).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZCompany).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZPost).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.ZDataSources).IsRequired(false).HasMaxLength(200);
        }
    }
}
