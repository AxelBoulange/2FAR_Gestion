using _2FAR_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using _2FAR_Gestion.Content;
using _2FAR_Gestion.Content.Eleve;
using _2FAR_Library.Ado;
using Promo = _2FAR_Library.Promo;
using MahApps.Metro.Controls;

namespace _2FAR_Gestion
{
    public partial class ListeEleves 
    {
        public ListeEleves()
        {
            InitializeComponent();
            cbb_promotion.ItemsSource = Ados.listePromotions;
            dtg_liste_utilisateur.ItemsSource = Ados.listeUtilisateurs;
        }

        public void ajouter_eleve(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new MenuNavbar(new AjouterEleve());
        }

        private void cbb_promo_invisible(object sender, EventArgs e)
        {
            cbb_text.Visibility = Visibility.Hidden;
        }

        private void tbx_recherche_est_cible(object sender, RoutedEventArgs e)
        {
            tbx_recherche.Clear();
            search_text.Visibility= Visibility.Hidden;
        }

        private void tbx_recherche_nest_plus_cible(object sender, RoutedEventArgs e)
        {
            if (tbx_recherche.Text.Length < 1)
            {
                search_text.Visibility = Visibility.Visible;

            }
        }

        private void tbx_recherche_texte_change(object sender, TextChangedEventArgs e)
        {
            List<_2FAR_Library.Utilisateur> elevesfiltrer = FiltrerEleves(tbx_recherche.Text);
            dtg_liste_utilisateur.ItemsSource =  elevesfiltrer;
        }
        private List<_2FAR_Library.Utilisateur> FiltrerEleves(string texteRecherche)
        {
            if (cbb_promotion.Text != "")
            {
                Promo p = Ados.listePromotions.Where(p => p.nomPromo == cbb_promotion.Text).First();
                List<_2FAR_Library.Utilisateur> utilisateurs = Ados.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == p.idPromo).ToList();
                return utilisateurs.Where(Utilisateur =>
            Utilisateur.nomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.prenomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.mailUtilisateur.ToLower().Contains(texteRecherche.ToLower()))
            .ToList();
            }
            else
            return AdoUtilisateur.getAdoUtilisateur(Connexion.GetConn()).Where(Utilisateur =>
            Utilisateur.nomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.prenomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.mailUtilisateur.ToLower().Contains(texteRecherche.ToLower()))
            .ToList();
        }




        private void cbb_promotion_selection_change(object sender, SelectionChangedEventArgs e)
        {
            string item = (string)cbb_promotion.SelectedItem;
            List<_2FAR_Library.Utilisateur> elevesfiltrer = FiltrerElevesParPromo(item);
            dtg_liste_utilisateur.ItemsSource = elevesfiltrer;
        }

        private List<_2FAR_Library.Utilisateur> FiltrerElevesParPromo(string item)
        {
            if (FiltrerEleves != null)
            {
                List<_2FAR_Library.Utilisateur> elevesfiltrer = FiltrerEleves(tbx_recherche.Text);
                return elevesfiltrer.Where(Utilisateur => Utilisateur.fk_id_promo == Ados.listePromotions.Where(p => p.nomPromo == item).First().idPromo).ToList();

            }
            else
            if (cbb_promotion.Text != "")
                return Ados.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == Ados.listePromotions.Where(p => p.nomPromo == item).First().idPromo).ToList();
            else
                return Ados.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == Ados.listePromotions.Where(p => p.nomPromo == item).First().idPromo).ToList();
        }

        private void remise_a_zero(object sender, EventArgs e)
        {
            if (tbx_recherche is TextBox) 
                tbx_recherche.Text= string.Empty;
            dtg_liste_utilisateur.ItemsSource = Ados.listeUtilisateurs;
        }
    }
}
