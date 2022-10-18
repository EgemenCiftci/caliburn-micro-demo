using Caliburn.Micro;

namespace CaliburnMicroDemo.ViewModels;

public class FirstPageViewModel : Screen
{
    private string _text = "First Page";

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            NotifyOfPropertyChange(() => Text);
        }
    }

    private int _pressCount = 0;

    private readonly IEventAggregator _eventAggregator;

    public FirstPageViewModel(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
    }

    public void ChangeMessage()
    {
        _pressCount++;
        Text = $"Presses = {_pressCount}";
    }

    public void ShowSecondPage()
    {
        _ = _eventAggregator.PublishOnUIThreadAsync(2);
    }
}
