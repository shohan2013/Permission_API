using Permission.Application;
using Permission.Infrastructure;

namespace Permission.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI().AddInfrastructureDI();
            return services;
        }
    }
}
