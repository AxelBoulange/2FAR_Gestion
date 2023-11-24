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
