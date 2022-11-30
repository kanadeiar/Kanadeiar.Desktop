namespace WpfUi.Windows;

public partial class AboutWindow : Window
{
    public AboutWindow()
    {
        InitializeComponent();
    }

    private void GitHubHyperLink_Click(object sender, RoutedEventArgs e)
    {
        var destinationurl = "https://github.com/kanadeiar/Kanadeiar.Desktop";
        var sInfo = new ProcessStartInfo(destinationurl)
        {
            UseShellExecute = true,
        };
        Process.Start(sInfo);
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }
}