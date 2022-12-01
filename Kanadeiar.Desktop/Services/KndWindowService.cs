namespace Kanadeiar.Desktop.Services;

public class KndWindowService : IKndWindowService
{
    public void Show<T>(object? dataContext = null) where T : Window, new()
    {
        var window = new T();
        window.DataContext = dataContext;
        window.Show();
    }
    public void ShowDialog<T>(object? dataContext = null) where T : Window, new()
    {
        var window = new T();
        window.DataContext = dataContext;
        window.ShowDialog();
    }
}