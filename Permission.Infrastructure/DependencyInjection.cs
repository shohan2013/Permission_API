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
                options.UseSqlServer("Data Source=10.35.117.135;Initial Catalog=MENUTEST;Persist Security Info=True;User ID=sohan.corpone;Password=Test@1234;Trust Server Certificate=True");
            });

            services.AddScoped<IEmplolyeeRepository,EmployeeRepository>();
            return services;
        }
    }
}
