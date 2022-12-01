namespace WpfDesktop.ViewModels;

/// <summary>
/// Вьюмодель окна о программе
/// </summary>
public class AboutWindowViewModel : KndWindowViewModel
{
    private string _name = "Простой образец настольного приложения";
    /// <summary>
    /// Название приложения
    /// </summary>
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