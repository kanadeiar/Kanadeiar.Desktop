namespace WpfDesktop.ViewModels;

public class AboutWindowViewModel : KndWindowViewModel
{
    private string _name = "Тестовое приложение";
    public string Name
    {
        get => _name;
        set => Set(ref _name, value);
    }

    public AboutWindowViewModel()
    {
        Title = "О программе ...";
    }
}