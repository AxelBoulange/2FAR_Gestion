using _2FAR_Gestion.Content;
using _2FAR_Library;
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
        AdoAll all;


        public PageAccueil(AdoAll allo)
        {
            all= allo;
       
            InitializeComponent();
        }

        private void CreationTpPage(object sender, RoutedEventArgs e)
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new FrameContent(new CreationTP());
                
            }
        }
        private void ListTpPage (object sender, RoutedEventArgs e)
        {
            
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new FrameContent(new ListeTp());
            }
        }
        private void VoirElevePage (object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new FrameContent(new VoirEleve());
            }
        }
        private void VoirPromosPage ( object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new FrameContent(new VoirPromos());
            }
        }
        private void DemandeValidationPage ( object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new FrameContent(new DemandeValidation());
            }
        }
    }
}
