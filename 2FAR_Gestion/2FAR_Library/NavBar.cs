using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;

namespace _2FAR_Library
{
    public class NavBar : StackPanel
    {
        public NavBar()
        {
            Grid.SetColumn(this, 0);
            this.Background = Brushes.Purple;
            this.Width = 100;
            
            this.Children.Add(new btn_NavBar("azer"));
        }
    }
    public class btn_NavBar : Button
    {
        public btn_NavBar(string name)
        {
            this.Content = name;
            this.Width = 80;
        }
    }
}
