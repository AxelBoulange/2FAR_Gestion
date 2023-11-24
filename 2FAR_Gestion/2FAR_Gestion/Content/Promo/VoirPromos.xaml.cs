using System;
using System.Collections.Generic;
using System.Windows;
using _2FAR_Library;

namespace _2FAR_Gestion
{
    public partial class VoirPromos
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
