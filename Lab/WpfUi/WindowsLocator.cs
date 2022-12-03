namespace WpfUi;

/// <summary>
/// Локатор окон
/// </summary>
public class WindowsLocator : IWindowsLocator
{
    /// <summary>
    /// Отобразить окно о программе
    /// </summary>
    public void AboutWindowShowDialog()
    {
        KndWindowTool.ShowDialog<AboutWindow>();
    }
}