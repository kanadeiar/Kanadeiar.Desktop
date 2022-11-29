namespace WpfInfra.ViewModels;

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

        Update();
    }

    private void Update()
    {
        Title = $"Заголовок приложения с сообщением: {_messageService.GetMessage()}";

        Message = _messageService.GetMessage();
    }
}