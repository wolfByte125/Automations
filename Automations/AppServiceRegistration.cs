using Automations.Services.CRUDServices;

namespace Automations
{
    public static class AppServiceRegistration
    {
        public static void AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<ICRUDService, CRUDService>();
        }
    }
}
