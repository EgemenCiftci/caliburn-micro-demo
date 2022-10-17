using Caliburn.Micro;
using CaliburnMicroDemo.ViewModels;
using System.Windows;

namespace CaliburnMicroDemo;

public class HelloBootstrapper : BootstrapperBase
{
    public HelloBootstrapper()
    {
        Initialize();
    }

    protected override void OnStartup(object sender, StartupEventArgs e)
    {
        _ = DisplayRootViewForAsync<ShellViewModel>();
    }
}
