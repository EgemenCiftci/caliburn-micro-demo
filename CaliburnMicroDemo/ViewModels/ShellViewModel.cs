using Caliburn.Micro;
using System.Threading;
using System.Threading.Tasks;

namespace CaliburnMicroDemo.ViewModels;

public class ShellViewModel : Conductor<IScreen>, IHandle<int>
{
    private readonly IEventAggregator _eventAggregator;

    public ShellViewModel(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
        _eventAggregator.SubscribeOnUIThread(this);

        _ = Task.Run(async () =>
        {
            await ShowFirstPageAsync();
        });
    }

    public async Task HandleAsync(int message, CancellationToken cancellationToken)
    {
        if (message == 1)
        {
            await ShowFirstPageAsync();
        }
        else if (message == 2)
        {
            await ShowSecondPageAsync();
        }
    }

    public Task ShowFirstPageAsync()
    {
        return ActivateItemAsync(IoC.Get<FirstPageViewModel>());
    }

    public Task ShowSecondPageAsync()
    {
        return ActivateItemAsync(new SecondPageViewModel(_eventAggregator));
    }
}
