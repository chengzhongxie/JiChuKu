using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 其他表彰F集合
    /// </summary>
    public class FOtherCommendation : FatherClass
    {
        /// <summary>
        /// 荣誉称号/获奖名称
        /// </summary>
        public string FHonoraryTitle { get; set; }
        /// <summary>
        /// 表彰（授予/评定）单位
        /// </summary>
        public string FCommendationUnit { get; set; }
        /// <summary>
        /// 表彰（授予/评定）日期
        /// </summary>
        public string FCommendationDate { get; set; }
        /// <summary>
        /// 表彰（授予/评定）文号
        /// </summary>
        public string FCommendationSymbol { get; set; }
        /// <summary>
        /// 法人基本数据id
        /// </summary>
        public string FLegalPersonID { get; set; }
        /// <summary>
        /// 法人基本数据
        /// </summary>
        public FLegalPerson FLegalPerson { get; set; }
    }
    public class FOtherCommendationConfiguration : IEntityTypeConfiguration<FOtherCommendation>
    {
        public void Configure(EntityTypeBuilder<FOtherCommendation> builder)
        {
            builder.Property(x => x.FHonoraryTitle).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCommendationUnit).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCommendationDate).IsRequired(false).HasMaxLength(200);
            builder.Property(x => x.FCommendationSymbol).IsRequired(false).HasMaxLength(200);
            builder.HasOne(x => x.FLegalPerson).WithMany(x => x.FOtherCommendations).HasForeignKey(x => x.FLegalPersonID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
