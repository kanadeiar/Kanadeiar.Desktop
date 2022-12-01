namespace Kanadeiar.Desktop.Tools;

/// <summary>
/// Интсрумент создания и открытия новых окон
/// </summary>
public static class KndWindowTool
{
    /// <summary>
    /// Открыть новое окно
    /// </summary>
    public static void Show<T>(object? dataContext = null) where T : Window, new()
    {
        var window = new T();
        window.DataContext = dataContext;
        window.Show();
    }
    /// <summary>
    /// Открыть новое диалоговое окно
    /// </summary>
    public static void ShowDialog<T>(object? dataContext = null) where T : Window, new()
    {
        var window = new T();
        window.DataContext = dataContext;
        window.ShowDialog();
    }
}