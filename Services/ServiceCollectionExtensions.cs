using Microsoft.Extensions.DependencyInjection;
using UnityBundleInspector.ViewModels;

namespace UnityBundleInspector.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services)
    {
        services.AddSingleton<MainViewModel>();
        
        return services;
    }
    
}