using AutoMapper;
using BLL.ServiceCollection;
using DAL.Entities;
using DAL.ServiceCollection;
using JiChuKu.ServiceCollection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace JiChuKu
{
    // Development（开发）
    //Staging（预演）
    //Production（生产）
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperTestService());
            });
        }

        public IConfiguration Configuration { get; }
        private MapperConfiguration _mapperConfiguration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            // 数据库连接
            var connectionString = Configuration["connectionStrings:productionInfoDbConnectionString"];
            services.AddDbContext<MyContext>(o => o.UseSqlServer(connectionString));
            services.AddBLLService();// 注册BLL逻辑
            services.AddFluentValidationService();// 注册数据校验
            //services.AddAutoMapper();//添加对AutoMapper的支持
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();//获取ip地址
            services.AddSingleton<IMapper>(sp => _mapperConfiguration.CreateMapper());
            services.AddDLLService();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            #region Nlog记日志
            loggerFactory.AddNLog();
            //将日志记录到数据库                 config/NLog.config
            //NLog.LogManager.LoadConfiguration("nlog.config").GetCurrentClassLogger();
            var connectionString = Configuration["connectionStrings:productionInfoDbConnectionString"];
            NLog.LogManager.Configuration.Variables["connectionString"] = connectionString;
            #endregion

            //系统环境判断
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    app.UseExceptionHandler();
            //}
            app.UseStatusCodePages(); // 界面优化
            app.UseMvc();

        }
    }
}
