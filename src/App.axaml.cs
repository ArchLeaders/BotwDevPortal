using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Generics;
using Avalonia.Generics.Builders;
using Avalonia.Markup.Xaml;
using BotwDevPortal.Views;

namespace BotwDevPortal;

public partial class App : Application
{
    public static string Title { get; set; } = "Botw Developer Portal";
    public static string Version { get; } = typeof(App).Assembly.GetName().Version?.ToString(3) ?? "-.-.-";
    public ShellView ShellView { get; set; } = new();

    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = WindowBuilder.Initialize(ShellView)
                .WithWindowColors("SystemChromeLowColor", "SystemBaseLowColor", chromeOpacity: 0.5)
                .Build();

            ShellView.ViewModel.Mod = desktop.Args?.FirstOrDefault(Directory.GetCurrentDirectory())!;
        }

        ApplicationLoader.Attach(this);
        base.OnFrameworkInitializationCompleted();
    }
}