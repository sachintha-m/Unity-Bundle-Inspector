using Microsoft.Extensions.DependencyInjection;
using UnityBundleInspector.Services;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using UnityBundleInspector.ViewModels;
using UnityBundleInspector.Views;

namespace UnityBundleInspector;

public partial class App : Application
{
    private ServiceProvider? _serviceProvider;
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        
        var services = new ServiceCollection();

        services.AddApplicationServices();
        
        _serviceProvider = services.BuildServiceProvider();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = _serviceProvider.GetRequiredService<MainViewModel>(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}