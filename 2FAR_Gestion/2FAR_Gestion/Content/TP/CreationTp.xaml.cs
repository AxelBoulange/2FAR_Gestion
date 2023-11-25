using System.Windows;

namespace _2FAR_Gestion
{
    public partial class CreationTp
    {

        public CreationTp()
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
