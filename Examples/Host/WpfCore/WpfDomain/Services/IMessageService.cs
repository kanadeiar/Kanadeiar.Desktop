namespace WpfDomain.Services;

/// <summary>
/// Сервис сообщений
/// </summary>
public interface IMessageService
{
    /// <summary>
    /// Получить сообщение
    /// </summary>
    public string GetMessage();
}