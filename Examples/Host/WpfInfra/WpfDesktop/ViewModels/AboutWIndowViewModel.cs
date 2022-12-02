namespace WpfDesktop.ViewModels;

/// <summary>
/// Вьюмодель окна о программе
/// </summary>
public class AboutWindowViewModel : KndWindowViewModel
{
    private string _name = "Образец настольного приложения";
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

    private ICommand? _GitHubHyperLinkCommand;
    /// <summary> 
    /// Открыть страницу с репозиторием проекта 
    /// </summary>
    public ICommand GitHubHyperLinkCommand => _GitHubHyperLinkCommand ??=
        new KndRelayCommand(OnGitHubHyperLinkCommandExecuted, CanGitHubHyperLinkCommandExecute);
    private bool CanGitHubHyperLinkCommandExecute(object p) => true;
    private void OnGitHubHyperLinkCommandExecuted(object p)
    {
        var destinationurl = "https://github.com/kanadeiar/Kanadeiar.Desktop";
        var sInfo = new ProcessStartInfo(destinationurl)
        {
            UseShellExecute = true,
        };
        Process.Start(sInfo);
    }
}