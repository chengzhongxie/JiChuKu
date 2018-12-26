﻿using IBLL;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.ServiceCollection
{
    public static class BLLService
    {
        // AddTransient瞬时模式：每次请求，都获取一个新的实例。即使同一个请求获取多次也会是不同的实例

        // AddScoped：每次请求，都获取一个新的实例。同一个请求获取多次会得到相同的实例

        // AddSingleton单例模式：每次都获取同一个实例
        public static IServiceCollection AddBLLService(this IServiceCollection service)
        {
            service.AddScoped<IFAdministrativeCoercionRepository, FAdministrativeCoercionRepository>();
            service.AddScoped<IFLegalPersonRepository, FLegalPersonRepository>();
            return service;
        }
    }
}
