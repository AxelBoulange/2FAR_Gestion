using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2FAR_Library.Graphique
{
    public class Carte : Grid
    {

        public Carte(string title, string content, List<Action> actionButtons)
        {
            var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("white"));
            Border border = new Border();
            border.BorderThickness = new Thickness(1);
            border.BorderBrush = brush;
            StackPanel stackPanel = new StackPanel();
            Height = 150;
            Children.Add(stackPanel);
            stackPanel.HorizontalAlignment = HorizontalAlignment.Right;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;
            stackPanel.Children.Add(new Btn("consulter", actionButtons[0]));
            stackPanel.Children.Add(new Btn("modifier", actionButtons[1]));
            stackPanel.Children.Add(new Btn("supprimer", actionButtons[2]));
            Children.Add(new title_Carte(title));
            Children.Add(new content_Carte(content));
            Margin = new Thickness(0, 0, 0, 20);
        }
        public Carte(string title, string content, Action actionButton)
        {
            Height = 100;
            StackPanel stackPanel = new StackPanel();
            Children.Add(stackPanel);
            stackPanel.HorizontalAlignment = HorizontalAlignment.Right;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;
            stackPanel.Children.Add(new Btn("consulter", actionButton));
            Children.Add(new title_Carte(title));
            Children.Add(new content_Carte(content));
            Margin = new Thickness(0, 0, 0, 20);
        }
    }
    public class title_Carte : Label
    {
        public title_Carte(string content)
        {
            var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("white"));
            HorizontalAlignment = HorizontalAlignment.Left;
            HorizontalContentAlignment = HorizontalAlignment.Center;
            VerticalContentAlignment = VerticalAlignment.Center;
            VerticalAlignment = VerticalAlignment.Center;
            Height = 100;
            Width = 80;
            Margin = new Thickness(10);
            Content = content;
            Foreground = brush;
            Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5e17eb"));

        }
    }
    public class content_Carte : Label
    {
        public content_Carte(string content)
        {
            HorizontalAlignment = HorizontalAlignment.Center;
            VerticalAlignment = VerticalAlignment.Center;
            Content = content;

        }
    }
}
