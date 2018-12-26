using DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
{
    //Add-Migration [名] 迁移
    //
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.Migrate();
        }
        #region 自然人
        public DbSet<ZNaturalPerson> ZNaturalPerson { get; set; }
        public DbSet<ZAdministrativeLicensing> ZAdministrativeLicensing { get; set; }
        public DbSet<ZAdministrativeSanction> ZAdministrativeSanction { get; set; }
        public DbSet<ZAdministrativeReward> ZAdministrativeReward { get; set; }
        public DbSet<ZOtherPenalties> ZOtherPenalties{ get; set; }
        public DbSet<ZOtherCommendation> ZOtherCommendation { get; set; }
        public DbSet<ZDishonestExecutor> ZDishonestExecutor { get; set; }
        public DbSet<ZAdministrativeCoercion> ZAdministrativeCoercion { get; set; }
        #endregion

        #region 法人
        public DbSet<FLegalPerson> FLegalPerson { get; set; }
        public DbSet<FAdministrativeCoercion> FAdministrativeCoercion { get; set; }
        public DbSet<FAdministrativeExamination> FAdministrativeExamination { get; set; }
        public DbSet<FAdministrativeLicensing> FAdministrativeLicensing { get; set; }
        public DbSet<FAdministrativeReward> FAdministrativeReward { get; set; }
        public DbSet<FAdministrativeSanction> FAdministrativeSanction { get; set; }
        public DbSet<FDishonestExecutor> FDishonestExecutor { get; set; }
        public DbSet<FOtherCommendation> FOtherCommendation { get; set; }
        public DbSet<FOtherPenalties> FOtherPenalties { get; set; }
        #endregion

        #region 日志/异常
        public DbSet<SysException> SysException { get; set; }
        public DbSet<SysLog> SysLog { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 自然人
            modelBuilder.ApplyConfiguration(new ZNaturalPersonConfiguration());
            modelBuilder.ApplyConfiguration(new ZAdministrativeLicensingConfiguration());
            modelBuilder.ApplyConfiguration(new ZAdministrativeSanctionConfiguration());
            modelBuilder.ApplyConfiguration(new ZAdministrativeRewardConfiguration());
            modelBuilder.ApplyConfiguration(new ZOtherPenaltiesConfiguration());
            modelBuilder.ApplyConfiguration(new ZOtherCommendationConfiguration());
            modelBuilder.ApplyConfiguration(new ZDishonestExecutorConfiguration());
            modelBuilder.ApplyConfiguration(new ZAdministrativeCoercionConfiguration());
            #endregion

            #region 法人
            modelBuilder.ApplyConfiguration(new FLegalPersonConfiguration());
            modelBuilder.ApplyConfiguration(new FAdministrativeCoercionConfiguration());
            modelBuilder.ApplyConfiguration(new FAdministrativeExaminationConfiguration());
            modelBuilder.ApplyConfiguration(new FAdministrativeLicensingConfiguration());
            modelBuilder.ApplyConfiguration(new FAdministrativeRewardConfiguration());
            modelBuilder.ApplyConfiguration(new FAdministrativeSanctionConfiguration());
            modelBuilder.ApplyConfiguration(new FDishonestExecutorConfiguration());
            modelBuilder.ApplyConfiguration(new FOtherCommendationConfiguration());
            modelBuilder.ApplyConfiguration(new FOtherPenaltiesConfiguration());
            #endregion

            #region 日志/异常
            modelBuilder.ApplyConfiguration(new SysExceptionConfiguration());
            modelBuilder.ApplyConfiguration(new SysLogConfiguration());
            #endregion
        }
    }
}
