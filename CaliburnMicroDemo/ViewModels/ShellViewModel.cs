using Caliburn.Micro;

namespace CaliburnMicroDemo.ViewModels;

public class ShellViewModel : Conductor<object>
{
    public ShellViewModel()
    {
        ShowFirstPage();
    }

    public void ShowFirstPage()
    {
        _ = ActivateItemAsync(new FirstPageViewModel());
    }
}
