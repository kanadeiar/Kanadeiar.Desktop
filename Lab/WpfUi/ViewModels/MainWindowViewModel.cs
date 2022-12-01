using Kanadeiar.Desktop.Services;

namespace WpfUi.ViewModels;

public class MainWindowViewModel : KndWindowViewModel
{
    private IMessageService _messageService;
    private IKndWindowService _windowService;

    private string _message = string.Empty;
    public string Message
    {
        get => _message;
        set => Set(ref _message, value);
    }

    public MainWindowViewModel(IMessageService messageService, IKndWindowService windowService)
    {
        _messageService = messageService ?? throw new ArgumentNullException(nameof(IMessageService));
        _windowService = windowService ?? throw new ArgumentNullException(nameof(IMessageService));
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
        _windowService.ShowDialog<AboutWindow>();
    }

    private void Update()
    {
        Title = $"Заголовок приложения с сообщением: {_messageService.GetMessage()}";

        Message = _messageService.GetMessage();
    }
}