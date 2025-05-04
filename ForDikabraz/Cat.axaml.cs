using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ForDikabraz;

public partial class Cat : Window
{
    public Cat() => InitializeComponent();

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => System.Diagnostics.Process.GetCurrentProcess().Kill();
}