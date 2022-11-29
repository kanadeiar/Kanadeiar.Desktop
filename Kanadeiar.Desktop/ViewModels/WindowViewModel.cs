namespace Kanadeiar.Desktop.ViewModels;

public class KndWindowViewModel : Base.KndViewModelBase
{
    private string _title = "<Заголовок приложения>";
    /// <summary> 
    /// Заголовок окна
    /// </summary>
    public string Title
    {
        get => _title;
        set => Set(ref _title, value);
    }

    public KndWindowViewModel()
    {

    }

    private ICommand? _CloseAppCommand;
    /// <summary> 
    /// Закрыть приложение 
    /// </summary>
    public ICommand CloseAppCommand => _CloseAppCommand ??=
        new KndRelayCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
    private bool CanCloseAppCommandExecute(object p) => true;
    private void OnCloseAppCommandExecuted(object p)
    {
        Application.Current.Shutdown();
    }
}