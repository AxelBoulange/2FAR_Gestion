using _2FAR_Gestion.classes;
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

namespace _2FAR_Gestion
{
    public partial class VoirEleve 
    {
        public VoirEleve()
        {
            InitializeComponent();

            List<_2FAR_Library.Promo> promo = AdoPromos.getAdoPromos();
            List<string> promo_string = new List<string>();
            foreach (var item in promo)
            {
                promo_string.Add(item.nomPromo);
            }
            cbb_promo.ItemsSource = promo_string;




            List<_2FAR_Library.Utilisateur>utilisateur= AdoUtilisateur.getAdoUtilisateur();
            List<string> nomPromo = new List<string>();
            foreach (Promo p in AdoPromos.getAdoPromos())
            {
                foreach (_2FAR_Library.Utilisateur u in utilisateur)
                {
                    if (u.promoUtilisateur == p.idPromo)
                    {
                        nomPromo.Add(p.nomPromo);
                    }
                }
            };
            datagrid.ItemsSource = AdoUtilisateur.getAdoUtilisateur();
}

        public void add_eleve(object sender, RoutedEventArgs e)
        {
            if (this.Parent is FrameContent fc)
            {
                fc.frameContent.Content = new AjouterEleve();
            }

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
                Promo p = AdoPromos.getAdoPromos().Where(p => p.nomPromo == cbb_promo.Text).First();
                List<_2FAR_Library.Utilisateur> user = AdoUtilisateur.getAdoUtilisateur().Where(Utilisateur => Utilisateur.promoUtilisateur == p.idPromo).ToList();
                return user.Where(Utilisateur =>
            Utilisateur.nomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.prenomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.mailUtilisateur.ToLower().Contains(texteRecherche.ToLower()))
            .ToList();
            }
            else
            return AdoUtilisateur.getAdoUtilisateur().Where(Utilisateur =>
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
                return elevesfiltrer.Where(Utilisateur => Utilisateur.promoUtilisateur == AdoPromos.getAdoPromos().Where(p => p.nomPromo == item).First().idPromo).ToList();

            }
            else
                return AdoUtilisateur.getAdoUtilisateur().Where(Utilisateur => Utilisateur.promoUtilisateur == AdoPromos.getAdoPromos().Where(p => p.nomPromo == item).First().idPromo).ToList();

        }
    }
}
