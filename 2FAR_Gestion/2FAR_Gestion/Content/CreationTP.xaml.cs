using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2FAR_Gestion
{
    public partial class CreationTP : Page
    {

        public CreationTP()
        {
            InitializeComponent();
        }

        private void Show2(object sender, RoutedEventArgs e)
        {
            border1.Visibility = Visibility.Hidden; border2.Visibility = Visibility.Visible;
        }

        private void Show1(object sender, RoutedEventArgs e)
        {
            border1.Visibility = Visibility.Visible; border2.Visibility = Visibility.Hidden;
        }
    }
}
