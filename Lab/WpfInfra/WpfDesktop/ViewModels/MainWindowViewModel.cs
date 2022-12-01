namespace WpfDesktop.ViewModels;

public class MainWindowViewModel : KndWindowViewModel
{
    private readonly IMessageService _messageService;
    private readonly IWindowsLocator _windowsLocator;

    private string _message = string.Empty;
    public string Message
    {
        get => _message;
        set => Set(ref _message, value);
    }

    public MainWindowViewModel(IMessageService messageService, IWindowsLocator windowsLocator)
    {
        _messageService = messageService ?? throw new ArgumentNullException(nameof(IMessageService));
        _windowsLocator = windowsLocator ?? throw new ArgumentNullException(nameof(IWindowsLocator));
        Title = "Главное окно приложения";
        Update();
    }

    private ICommand? _ShowAboutCommand;
    /// <summary> 
    /// Открыть окно о программе 
    /// </summary>
    public ICommand ShowAboutCommand => _ShowAboutCommand ??=
        new KndRelayCommand(OnShowAboutCommandExecuted, CanShowAboutCommandExecute);
    private bool CanShowAboutCommandExecute(object p) => true;
    private void OnShowAboutCommandExecuted(object p)
    {
        _windowsLocator.AboutWindowShowDialog();
    }

    private void Update()
    {
        Title = $"Заголовок приложения с сообщением: {_messageService.GetMessage()}";

        Message = _messageService.GetMessage();
    }
}