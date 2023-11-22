using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using _2FAR_Gestion.classes;
using _2FAR_Library;

namespace _2FAR_Gestion
{
    public partial class ListeTp : Page
    {
        public ListeTp()
        {
            Dictionary<string,Action> actionsButton = new Dictionary<string,Action>() { {"consulter",consulter},{"modifier",modifier},{"supprimer",supprimer}};
            
            InitializeComponent();
            
            this.listCartes.Children.Add(new Carte("TPCOOL1", "PERNELLE", actionsButton));
            this.listCartes.Children.Add(new Carte("TPCOOL2", "COURBEZ", actionsButton));
            this.listCartes.Children.Add(new Carte("TPNULACHIER", "ANGLAIS", actionsButton));
        }
        private void consulter()
        {
            
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
