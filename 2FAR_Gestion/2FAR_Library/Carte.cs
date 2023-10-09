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
        public Carte(string title, string content)
        {
            //Grid.SetColumn(this, 1);
            Grid.SetRow(this, 1);
            this.Height = 150;
            //this.Width = 500;
            this.Background = Brushes.Brown;
            this.Children.Add(new title_Carte(title));
            this.Children.Add(new content_Carte(content));
            this.Children.Add(new btn_Carte("Consulter"));
            this.Margin = new Thickness(0, 0, 0, 20);
        }
    }
    public class btn_Carte: Button
    {
        public btn_Carte(string name)
        {
            HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            VerticalAlignment = System.Windows.VerticalAlignment.Top;
            this.Margin = new Thickness(0, 0, 20, 0);
            this.Content = name;
            this.Width = 80;
            this.Height = 25;
            this.Background = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));
            
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
