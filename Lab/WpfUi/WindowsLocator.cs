using Kanadeiar.Desktop.Tools;

namespace WpfUi;

/// <summary>
/// Локатор окон
/// </summary>
public class WindowsLocator : IWindowsLocator
{
    // private KndWindowService _windowService;
    // public WindowsLocator(KndWindowService windowService)
    // {
    //     _windowService = windowService ?? throw new ArgumentNullException(nameof(KndWindowService));
    // }

    public void AboutWindowShowDialog()
    {
        KndWindowTool.ShowDialog<AboutWindow>();
    }
}