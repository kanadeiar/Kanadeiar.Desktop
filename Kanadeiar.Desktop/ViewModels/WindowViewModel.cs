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

    private ICommand? _CloseWindowCommand;
    /// <summary> 
    /// Закрыть окно 
    /// </summary>
    public ICommand CloseWindowCommand => _CloseWindowCommand ??=
        new KndRelayCommand(OnCloseWindowCommandExecuted, CanCloseWindowCommandExecute);
    private bool CanCloseWindowCommandExecute(object p) => true;
    private void OnCloseWindowCommandExecuted(object p)
    {
        var w = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
        w?.Close();
    }
}