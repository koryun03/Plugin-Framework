using Microsoft.Extensions.DependencyInjection;
using PluginFramework.Application.ServiceInterfaces;
using PluginFramework.Application.Services;

namespace PluginFramework.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IPluginService, PluginService>();
    }
}
