using FluentValidation;
using JiChuKu.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JiChuKu.ServiceCollection
{
    public static class FluentValidationService
    {
        public static IServiceCollection AddFluentValidationService(this IServiceCollection service)
        {
            service.AddScoped<IValidator<FAdministrativeCoercionTest>, FAdministrativeCoercionTestValidator>();
            service.AddScoped<IValidator<FLegalPersonTest>, FLegalPersonTestValidator>();
            return service;
        }
    }
}
