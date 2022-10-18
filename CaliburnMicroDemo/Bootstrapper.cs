using Caliburn.Micro;
using CaliburnMicroDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;

namespace CaliburnMicroDemo;

public class Bootstrapper : BootstrapperBase
{
    private SimpleContainer _container = new SimpleContainer();

    public Bootstrapper()
    {
        Initialize();
    }

    protected override void Configure()
    {
        _ = _container.Singleton<IWindowManager, WindowManager>();
        _ = _container.Singleton<IEventAggregator, EventAggregator>();
        _ = _container.PerRequest<ShellViewModel>();
        _ = _container.PerRequest<FirstPageViewModel>();
        _ = _container.PerRequest<SecondPageViewModel>();
    }

    protected override async void OnStartup(object sender, StartupEventArgs e)
    {
        await DisplayRootViewForAsync<ShellViewModel>();
    }

    protected override object GetInstance(Type service, string key)
    {
        return _container.GetInstance(service, key);
    }

    protected override IEnumerable<object> GetAllInstances(Type service)
    {
        return _container.GetAllInstances(service);
    }

    protected override void BuildUp(object instance)
    {
        _container.BuildUp(instance);
    }
}
