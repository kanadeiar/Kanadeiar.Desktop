namespace Kanadeiar.Desktop.Services;

public interface IKndWindowService
{
    public void Show<T>(object? DataContext = null) where T : Window, new();
    public void ShowDialog<T>(object? DataContext = null) where T : Window, new();
}