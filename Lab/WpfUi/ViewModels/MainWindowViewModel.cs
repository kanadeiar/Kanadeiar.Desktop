namespace WpfUi.ViewModels;

public class MainWindowViewModel : KndWindowViewModel
{
    private IMessageService _messageService;

    private string _message = string.Empty;
    public string Message
    {
        get => _message;
        set => Set(ref _message, value);
    }

    public MainWindowViewModel(IMessageService messageService)
    {
        _messageService = messageService ?? throw new ArgumentNullException(nameof(IMessageService));
        Title = "Главное окно приложения";
        Update();
    }

    private ICommand? _ShowAboutCommand;
    /// <summary> 
    /// Открыть приложение о программе 
    /// </summary>
    public ICommand ShowAboutCommand => _ShowAboutCommand ??=
        new KndRelayCommand(OnShowAboutCommandExecuted, CanShowAboutCommandExecute);
    private bool CanShowAboutCommandExecute(object p) => true;
    private void OnShowAboutCommandExecuted(object p)
    {
        var form = new AboutWindow();
        form.ShowDialog();
    }

    private void Update()
    {
        Title = $"Заголовок приложения с сообщением: {_messageService.GetMessage()}";

        Message = _messageService.GetMessage();
    }
}