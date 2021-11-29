using Module2HW6.Services.Abstractions;
using Module2HW6.Services;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Module2HW6
{
    public class Startup
    {
        public void Run()
        {
            var serviceProvider = ConfigureServices();
            var app = serviceProvider?.GetService<Application>();
            app?.Run();
        }

        public ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ICabCompanyService, CabCompanyService>();
            services.AddTransient<ICarProvider, CarProvider>();
            services.AddTransient<Application>();

            return services.BuildServiceProvider();
        }
    }
}
