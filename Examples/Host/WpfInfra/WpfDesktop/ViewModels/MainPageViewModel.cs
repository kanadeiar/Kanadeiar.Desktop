namespace WpfDesktop.ViewModels;

/// <summary>
/// Вьюмодель главной страницы
/// </summary>
public class MainPageViewModel : KndViewModelBase
{
    private readonly IMessageService _messageService;

    private string _message = string.Empty;
    /// <summary>
    /// Сообщение на главной странице
    /// </summary>
    public string Message
    {
        get => _message;
        set => Set(ref _message, value);
    }

    public MainPageViewModel(IMessageService messageService)
    {
        _messageService = messageService ?? throw new ArgumentNullException(nameof(IMessageService));
        Update();
    }

    private void Update()
    {
        Message = _messageService.GetMessage();
    }
}