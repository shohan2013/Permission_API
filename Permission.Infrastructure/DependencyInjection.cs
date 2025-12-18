using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Permission.Core.Interfaces;
using Permission.Infrastructure.Data;
using Permission.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer("Your Connection String");
            });

            services.AddScoped<IEmplolyeeRepository,EmployeeRepository>();
            return services;
        }
    }
}
