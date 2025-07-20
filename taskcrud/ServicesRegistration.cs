using taskcrud.Services.Abstracts;
using taskcrud.Services.Implements;

namespace taskcrud
{
    public static class ServicesRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryServices, CategoryServices>();
            return services;
        }
    }
}
