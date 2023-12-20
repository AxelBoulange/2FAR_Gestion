using System;
using System.Collections.Generic;
using System.Windows;
using _2FAR_Library;
using _2FAR_Gestion.Content;
using _2FAR_Gestion.Content.Promo;
using System.Windows.Controls;

namespace _2FAR_Gestion
{
    public partial class ListePromos
    {
        public ListePromos()
        {
            Dictionary<string, Action<object, EventArgs>> actionsButton = new Dictionary<string, Action<object, EventArgs>> { { "Voir les TPs", voir_Les_Tps }, { "Modifier", modifier }, { "Supprimer", supprimer } };

            InitializeComponent();

            foreach (var promo in Ados.listePromotions)
            {
                int count = 0;
                foreach (var utilisateur in Ados.listeUtilisateurs) {
                    if (utilisateur.fk_id_promo == promo.idPromo)
                    {
                        count++;
                    }
                 }
                this.listCartes.Children.Add(new Carte("Nombre d'élève : " + count.ToString(), promo.nomPromo, actionsButton, 18, 25, promo));
            }
        }

        private void voir_Les_Tps(object o, EventArgs e)
        {
            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c)
            {
                var promo = c.objectCarte;
                if (promo is _2FAR_Library.Promo) 
                    Application.Current.MainWindow.Content = new MenuNavbar(new ListeTpPromos((Promo)promo));
            }
        }
        private void modifier(object o, EventArgs e)
        {

            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c)
            {
                var promo = c.objectCarte;
                if (promo is _2FAR_Library.Promo)
                {
                    Application.Current.MainWindow.Content = new MenuNavbar(new ActionPromos((Promo)promo));
                }
            }
        }

        private void supprimer(object o, EventArgs e)
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
            Application.Current.MainWindow.Content = new MenuNavbar(new ActionPromos());

        }
    }
}
