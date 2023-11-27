using _2FAR_Gestion.Content;
using System.Windows;

namespace _2FAR_Gestion
{


    public partial class PageAccueil
    {
        public PageAccueil()
        {
            InitializeComponent();
        }
        private void CreationTpPage(object sender, RoutedEventArgs e)
        {
            if (this.Parent is MainWindow mw)
            {
                mw.Content = new MenuNavbar(new CreationTp(),mw);
                
            }
        }
        private void ListTpPage (object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new MenuNavbar(new ListeTp(),mw);
            }
        }
        private void VoirElevePage (object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new MenuNavbar(new VoirEleves(mw),mw);
            }
        }
        private void VoirPromosPage ( object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new MenuNavbar(new VoirPromos(),mw);
            }
        }
        private void DemandeValidationPage ( object sender, RoutedEventArgs e)
        {
            if(this.Parent is MainWindow mw)
            {
                mw.Content = new MenuNavbar(new DemandeValidation(),mw);
            }
        }
    }
}
