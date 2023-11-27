using System;
using System.Collections.Generic;
using System.Windows;
using _2FAR_Library;
using _2FAR_Gestion.Content;
using _2FAR_Gestion.Content.Promo;

namespace _2FAR_Gestion
{
    public partial class VoirPromos
    {
        MainWindow mw;
        int id;
        public VoirPromos(MainWindow mw)
        {
            this.mw = mw;
           this.id = 0;
            Dictionary<string, Action<int>> actionsButton = new Dictionary<string, Action<int>>() { { "consulter", consulter }, { "modifier", modifier }, { "supprimer", supprimer } };

            InitializeComponent();

                        foreach (var promo in MainWindow.listePromotions)
            {
                int count = 0;
                foreach (var utilisateur in MainWindow.listeUtilisateurs) {
                    if (utilisateur.fk_id_promo == promo.idPromo)
                    {
                        count++;
                    }
                 }
                this.listCartes.Children.Add(new Carte("Nombre d'élève : " + count.ToString(), promo.nomPromo, actionsButton, 18, 25, promo.idPromo));
            }
        }

        private void consulter(int id)
        {
        }
        private void modifier(int id)
        {
            
            mw.Content = new MenuNavbar(new ActionPromos(id),mw);
        }

        private void supprimer(int id)
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

        private void add_promo(object sender, RoutedEventArgs e)
        {
            mw.Content = new MenuNavbar(new ActionPromos(), mw);

        }
    }
}
