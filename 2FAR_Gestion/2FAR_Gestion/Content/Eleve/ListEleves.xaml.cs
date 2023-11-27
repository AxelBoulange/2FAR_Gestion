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
    public partial class VoirEleves 
    {
        private MainWindow mw;
        public VoirEleves(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;

            List<_2FAR_Library.Promo> promo = MainWindow.listePromotions;
            List<string> promo_string = new List<string>();
            foreach (var item in promo)
            {
                promo_string.Add(item.nomPromo);
            }
            cbb_promo.ItemsSource = promo_string;




            List<_2FAR_Library.Utilisateur> utilisateur = MainWindow.listeUtilisateurs;
            List<string> nomPromo = new List<string>();
            foreach (Promo p in MainWindow.listePromotions)
            {
                foreach (_2FAR_Library.Utilisateur u in utilisateur)
                {
                    if (u.fk_id_promo == p.idPromo)
                    {
                        nomPromo.Add(p.nomPromo);
                    }
                }
            };
            datagrid.ItemsSource = MainWindow.listeUtilisateurs;
        }

        public void add_eleve(object sender, EventArgs e)
        {
            //   ((FrameContent)this.Parent).frameContent.Content = new AjouterEleve();
            mw.Content = new MenuNavbar(new AjouterEleve(), mw);

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
                Promo p = MainWindow.listePromotions.Where(p => p.nomPromo == cbb_promo.Text).First();
                List<_2FAR_Library.Utilisateur> user = MainWindow.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == p.idPromo).ToList();
                return user.Where(Utilisateur =>
            Utilisateur.nomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.prenomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
            Utilisateur.mailUtilisateur.ToLower().Contains(texteRecherche.ToLower()))
            .ToList();
            }
            else
            return MainWindow.listeUtilisateurs.Where(Utilisateur =>
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
                return elevesfiltrer.Where(Utilisateur => Utilisateur.fk_id_promo == AdoPromos.getAdoPromos().Where(p => p.nomPromo == item).First().idPromo).ToList();

            }
            else
            if (cbb_promo.Text != "")
            {
                return MainWindow.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == AdoPromos.getAdoPromos().Where(p => p.nomPromo == item).First().idPromo).ToList();

            }
            else
            return MainWindow.listeUtilisateurs.Where(Utilisateur => Utilisateur.fk_id_promo == AdoPromos.getAdoPromos().Where(p => p.nomPromo == item).First().idPromo).ToList();

        }

        private void reset(object sender, EventArgs e)
        {
            if (tbx_search is TextBox) 
            {
                tbx_search.Text= string.Empty;
            }
            datagrid.ItemsSource = MainWindow.listeUtilisateurs;


        }
    }
}
