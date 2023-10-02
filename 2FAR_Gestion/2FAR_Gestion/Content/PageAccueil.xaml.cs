using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2FAR_Gestion
{


    public partial class PageAccueil : Page
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void CreationTpPage(object sender, RoutedEventArgs e)
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new CreationTP();
            }
        }
        private void VoirTpPage (object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new ListeTp();
            }
        }
        private void VoirElevePage (object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new VoirEleve();
            }
        }
        private void VoirPromosPage ( object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new VoirPromos();
            }
        }
        private void DemandeValidationPage ( object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new DemandeValidation();
            }
        }


    }
}
