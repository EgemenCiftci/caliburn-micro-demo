using Caliburn.Micro;

namespace CaliburnMicroDemo.ViewModels;

public class SecondPageViewModel : Screen
{
    private string _text = "Second Page";

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            NotifyOfPropertyChange(() => Text);
        }
    }

    private readonly IEventAggregator _eventAggregator;

    public SecondPageViewModel(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
    }

    public void ShowFirstPage()
    {
        _ = _eventAggregator.PublishOnUIThreadAsync(1);
    }
}
