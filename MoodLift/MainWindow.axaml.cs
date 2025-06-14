using Avalonia.Controls;
using Avalonia.Media;
using System.Collections.Generic;

namespace MoodLift
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void bYes_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Cat cat = new();
            cat.Show();
            this.Close();
        }

        private List<string> Messages = new List<string>(5)
        {
            "You must be joking, it's definitely you!",
            "Oh really?",
            "Is that so?",
            "You liar!",
            "OK, I got you!"
        };

        private void bNo_PointerEntered(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (Messages.Count > 0)
            {
                MessageWindow messageWindow = new(Messages[0]);
                messageWindow.Show();
                Messages.RemoveAt(0);
            }
            else
            { 
                // Avalonia.Thickness bYesMargin = bYes.Margin; 
                // bYes.Margin = bNo.Margin; 
                // bNo.Margin = bYesMargin;
                (bYes.Margin, bNo.Margin) = (bNo.Margin, bYes.Margin);
            }
        }
    }
}