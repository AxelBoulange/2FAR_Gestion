using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;


namespace _2FAR_Library
{
    public class NavBar : StackPanel
    {
        public NavBar()
        {
            Grid.SetColumn(this, 0);

            // Créer un pinceau avec la couleur hexadécimale
            var brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));
            this.Background = brush;
            this.Width = 100;
            this.Children.Add(new Btn("CabinetFiles", 60, 60));
            this.Children.Add(new Btn("CabinetFilesVariant", 60, 60));
            this.Children.Add(new Btn("People", 60, 60));
            this.Children.Add(new Btn("PeopleMultiple", 60, 60));
            this.Children.Add(new Btn("Check", 60, 60));


        }
    }
    public class Btn : Button
    {
        public Btn(string name, int SizeWidth ,int SizeHeight)
        {
            this.Width = SizeWidth;
            this.Height = SizeHeight;

            this.Content = new PackIconModern
            {
                Kind = (PackIconModernKind)Enum.Parse(typeof(PackIconModernKind), name),
                Height = SizeHeight/1.75,
                Width = SizeWidth/1.75,
                
            };
            this.BorderThickness = new Thickness(0);
            this.Foreground = Brushes.White;
            this.Background = Brushes.Transparent;
            this.FontSize = SizeHeight;
            this.Margin = new Thickness(0, 20, 0, 0);
        }
    }

        

}
