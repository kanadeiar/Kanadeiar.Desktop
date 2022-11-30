namespace WpfUi.ViewModels;

public class MainPageViewModel : KndViewModelBase
{
    private IMessageService _messageService;

    private string _message = string.Empty;
    public string Message
    {
        get => _message;
        set => Set(ref _message, value);
    }

    public MainPageViewModel(IMessageService messageService)
    {
        _messageService = messageService;

        Update();
    }

    private void Update()
    {
        Message = _messageService.GetMessage();
    }
}