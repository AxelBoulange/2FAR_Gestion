using MahApps.Metro.IconPacks;
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
    internal class Button_icon : Button
    {
        public Button_icon(string name, int SizeWidth, int SizeHeight, Action click)
        {
            Width = SizeWidth;
            Height = SizeHeight;

            Content = new PackIconModern
            {
                Kind = (PackIconModernKind)Enum.Parse(typeof(PackIconModernKind), name),
                Height = SizeHeight / 1.75,
                Width = SizeWidth / 1.75,
            };
            BorderThickness = new Thickness(0);
            Foreground = Brushes.White;
            Background = Brushes.Transparent;
            FontSize = SizeHeight;
            Margin = new Thickness(0, 20, 0, 0);
            Click += (sender, e) => click.Invoke();
        }
    }

    public class Btn : Button
    {
        public Btn(string name, Action click)
        {
            HorizontalAlignment = HorizontalAlignment.Right;
            VerticalAlignment = VerticalAlignment.Center;
            var brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("white"));
            Margin = new Thickness(0, 0, 20, 0);
            Content = name;
            Width = 150;
            Height = 35;
            Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5e17eb"));
            Foreground = brush;
            Click += (sender, e) => click.Invoke();

        }
    }

}
