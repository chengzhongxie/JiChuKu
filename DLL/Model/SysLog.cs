using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Model
{
    /// <summary>
    /// 日志
    /// </summary>
    public class SysLog
    {

        public int Id { get; set; }
        public string Application { get; set; }
        public DateTime Logged { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Logger { get; set; }
        public string Callsite { get; set; }
        public string Exception { get; set; }
    }
    public class SysLogConfiguration : IEntityTypeConfiguration<SysLog>
    {
        public void Configure(EntityTypeBuilder<SysLog> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Application).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Level).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Message).IsRequired();
            builder.Property(c => c.Logger).HasMaxLength(250);
        }
    }
}
