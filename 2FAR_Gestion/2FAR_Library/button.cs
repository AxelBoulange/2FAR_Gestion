using MahApps.Metro.IconPacks;
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
    internal class Button_icon : Button
    {
        public Button_icon(string name, int SizeWidth, int SizeHeight, Action click)
        {
            this.Width = SizeWidth;
            this.Height = SizeHeight;

            this.Content = new PackIconModern
            {
                Kind = (PackIconModernKind)Enum.Parse(typeof(PackIconModernKind), name),
                Height = SizeHeight / 1.75,
                Width = SizeWidth / 1.75,
            };
            this.BorderThickness = new Thickness(0);
            this.Foreground = Brushes.White;
            this.Background = Brushes.Transparent;
            this.FontSize = SizeHeight;
            this.Margin = new Thickness(0, 20, 0, 0);
            this.Click += (sender, e) => click.Invoke();
        }
    }

    public class Btn : Button
    {
        public Btn(string name, Action click)
        {
            HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;
            this.Margin = new Thickness(0, 0, 20, 0);
            this.Content = name;
            this.Width = 80;
            this.Height = 25;
            this.Background = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));

        }
    }

}
