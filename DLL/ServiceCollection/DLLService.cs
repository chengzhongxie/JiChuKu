using DAL.IRepositories;
using DAL.Model;
using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ServiceCollection
{
    public static class DLLService
    {
        public static IServiceCollection AddDLLService(this IServiceCollection service)
        {
            service.AddScoped<IEnhancedRepository<FLegalPerson>, EfEnhancedRepository<FLegalPerson>>();
            return service;
        }
    }
}
