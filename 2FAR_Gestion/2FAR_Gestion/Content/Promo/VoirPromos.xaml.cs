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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _2FAR_Gestion.Content;
using _2FAR_Library;

namespace _2FAR_Gestion
{
    public partial class VoirPromos : Page
    {
        public VoirPromos()
        {
            Dictionary<string,Action> actionsButton = new Dictionary<string,Action>() { {"consulter",consulter},{"modifier",modifier},{"supprimer",supprimer}};
            InitializeComponent();
            
            this.listCartes.Children.Add(new Carte("BTS", "Bts2", actionsButton));
            this.listCartes.Children.Add(new Carte("BTS", "Bts1", actionsButton));
            this.listCartes.Children.Add(new Carte("BTSsio", "BtsSIO", actionsButton));
            
        }

        private void consulter()
        {
            // if (this.Parent is MainWindow mw)
            // {
            //     mw.Content = new FrameContent(new AjouterPromo());
            //
            // }
        }
        private void modifier()
        {
           this.listCartes.Children.Clear();
        }

        private void supprimer()
        {
            MessageBoxResult result = MessageBox.Show("Étes-Vous sur de vouloir supprimer cette promo", "Vérification", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                
            }
            else if (result == MessageBoxResult.Cancel)
            {
                
            }
            else
            {
                //impossible mais oklm
                MessageBox.Show("Erreur Inconnue");
            }
        }
    }
}
