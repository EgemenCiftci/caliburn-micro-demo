using Caliburn.Micro;

namespace CaliburnMicroDemo.ViewModels;

public class FirstPageViewModel : PropertyChangedBase
{
    private string _message = "Yolo";

    public string Message
    {
        get => _message;
        set
        {
            _message = value;
            NotifyOfPropertyChange(() => Message);
        }
    }

    private int _pressCount = 0;

    public void ChangeMessage()
    {
        _pressCount++;
        Message = $"Presses = {_pressCount}";
    }
}
