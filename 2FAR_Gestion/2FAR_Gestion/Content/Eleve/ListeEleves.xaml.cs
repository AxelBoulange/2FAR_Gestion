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

            List<string> promo_string = new List<string>();
            foreach (var item in Ados.listePromotions)
            {
                promo_string.Add(item.nomPromo);
            }
            cbb_promo.ItemsSource = promo_string;
            
            
            List<string> nomPromo = new List<string>();
            foreach (Promo p in Ados.listePromotions)
            {
                foreach (_2FAR_Library.Utilisateur u in Ados.listeUtilisateurs)
                {
                    if (u.fk_id_promo == p.idPromo)
                    {
                        nomPromo.Add(p.nomPromo);
                    }
                }
            };
            datagrid.ItemsSource = Ados.listeUtilisateurs;
        }

        public void add_eleve(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new MenuNavbar(new AjouterEleve());
        }

        private void cbb_promo_Drop(object sender, EventArgs e)
        {
            cbb_text.Visibility = Visibility.Hidden;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            tbx_search.Clear();
            search_text.Visibility= Visibility.Hidden;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbx_search.Text.Length < 1)
            {
                search_text.Visibility = Visibility.Visible;

            }
        }

        private void tbx_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = tbx_search.Text;
            List<_2FAR_Library.Utilisateur> elevesfiltrer = FiltrerEleves(text);
            datagrid.ItemsSource =  elevesfiltrer;
        }
        private List<_2FAR_Library.Utilisateur> FiltrerEleves(string texteRecherche)
        {
            if (cbb_promo.Text != "")
            {
                Promo p = Ados.listePromotions.Where(p => p.nomPromo == cbb_promo.Text).First();
                List<_2FAR_Library.Utilisateur> user = Ados.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == p.idPromo).ToList();
                return user.Where(Utilisateur =>
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




        private void cbb_promo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = (string)cbb_promo.SelectedItem;
            List<_2FAR_Library.Utilisateur> elevesfiltrer = FiltrerElevesByPromo(item);
            datagrid.ItemsSource = elevesfiltrer;
        }

        private List<_2FAR_Library.Utilisateur> FiltrerElevesByPromo(string item)
        {
            if (FiltrerEleves != null)
            {
                List<_2FAR_Library.Utilisateur> elevesfiltrer = FiltrerEleves(tbx_search.Text);
                return elevesfiltrer.Where(Utilisateur => Utilisateur.fk_id_promo == Ados.listePromotions.Where(p => p.nomPromo == item).First().idPromo).ToList();

            }
            else
            if (cbb_promo.Text != "")
                return Ados.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == Ados.listePromotions.Where(p => p.nomPromo == item).First().idPromo).ToList();
            else
                return Ados.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == Ados.listePromotions.Where(p => p.nomPromo == item).First().idPromo).ToList();
        }

        private void reset(object sender, EventArgs e)
        {
            if (tbx_search is TextBox) 
                tbx_search.Text= string.Empty;
            datagrid.ItemsSource = Ados.listeUtilisateurs;
        }
    }
}
