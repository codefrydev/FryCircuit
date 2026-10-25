using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using FryCircuit.UI.ViewModels;
using FryCircuit.UI.Views;
using FryCircuit.UI.Theming;

namespace FryCircuit.Browser;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is ISingleViewApplicationLifetime singleView)
        {
            var vm = new MainWindowViewModel();
            var view = new CircuitStudioView
            {
                DataContext = vm
            };
            CircuitThemeService.Instance.TrackResourceRoot(view);
            singleView.MainView = view;
        }

        base.OnFrameworkInitializationCompleted();
    }
}
