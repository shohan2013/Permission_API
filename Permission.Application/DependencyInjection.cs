using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Permission.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddMediatR(typeof(DependencyInjection).Assembly);

            return services;
        }
    }
}
