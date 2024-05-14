using APIGateway.API.Services;

namespace APIGateway.API.Core
{
    public static class CoreModule
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddHttpClient();

            services.AddSingleton<IRefDataService, RefDataService>();

            return services;
        }
    }
}
