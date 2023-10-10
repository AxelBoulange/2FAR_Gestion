using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2FAR_Library
{
    public class Carte : Grid
    {
        
        public Carte(string title, string content, List <Action> actionButtons)
        {
            //Grid.SetColumn(this, 1);
            
            Grid.SetRow(this, 1);
            this.Height = 100;
            //this.Width = 500;
            StackPanel stackPanel = new StackPanel();
            this.Children.Add(stackPanel);
            stackPanel.HorizontalAlignment = HorizontalAlignment.Right;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;
            stackPanel.Children.Add(new Btn("consulter", actionButtons[0]));
            stackPanel.Children.Add(new Btn("modifier", actionButtons[1]));
            stackPanel.Children.Add(new Btn("supprimer", actionButtons[2]));
            this.Background = Brushes.Brown;
            this.Children.Add(new title_Carte(title));
            this.Children.Add(new content_Carte(content));
            this.Margin = new Thickness(0, 0, 0, 20);
        }
        public Carte (string title, string content, Action actionButton)
        {
            Grid.SetRow (this, 1);
            this.Height = 100;
            StackPanel stackPanel = new StackPanel();
            this.Children.Add(stackPanel);
            stackPanel.HorizontalAlignment= HorizontalAlignment.Right;
            stackPanel.VerticalAlignment= VerticalAlignment.Center;
            stackPanel.Children.Add(new Btn("consulter", actionButton));
            this.Children.Add(new title_Carte (title));
            this.Children.Add(new content_Carte (content));
            this.Margin = new Thickness(0, 0, 0, 20);
        }
    }
    public class title_Carte : Label
    {
        public title_Carte(string content)
        {
            HorizontalAlignment= System.Windows.HorizontalAlignment.Left;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;
            Height = 100;
            Width = 80;
            this.Margin = new Thickness(10);
            this.Content = content;
            this.Background = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));

        }
    }
    public class content_Carte : Label
    {
        public content_Carte(string content)
        {
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;
            this.Content=content;
        }
    }
}
