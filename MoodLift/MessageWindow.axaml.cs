using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MoodLift;

public partial class MessageWindow : Window
{
    public MessageWindow(string Message)
    {
        InitializeComponent();

        lMessage.Content = Message;
    }

    private void bOk_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => this.Close();
}