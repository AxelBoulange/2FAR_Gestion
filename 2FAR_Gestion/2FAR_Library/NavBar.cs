using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2FAR_Library
{
    public class NavBar : StackPanel
    {
        public NavBar()
        {
            Grid.SetColumn(this, 0);
            this.Background = Brushes.Purple;
        }
    }
}
