namespace WpfUi.Controls;

public partial class MessageControl : UserControl
{
    public static readonly DependencyProperty MessageProperty =
        DependencyProperty.Register("Message",
        typeof(string),
        typeof(MessageControl),
        new PropertyMetadata(default(string)));
    [Description("Сообщение")]
    public string Message
    {
        get => (string)GetValue(MessageProperty);
        set => SetValue(MessageProperty, value);
    }
    public MessageControl()
    {
        InitializeComponent();
    }
}
