using _2FAR_Gestion.classes;
using _2FAR_Library;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Reflection.Emit;
using Microsoft.VisualBasic;
using _2FAR_Gestion.Content;
using MahApps.Metro.Controls;
using _2FAR_Gestion.Content.Eleve;
using _2FAR_Library.Ado;

namespace _2FAR_Gestion
{
    public partial class VoirEleve : Page
    {
        public VoirEleve()
        {
            InitializeComponent();

            _2FAR_Library.Promo promo1 = new _2FAR_Library.Promo(0, "SIO ALT");
            _2FAR_Library.Promo promo2 = new _2FAR_Library.Promo(1, "SIO TP");
            _2FAR_Library.Promo promo3 = new _2FAR_Library.Promo(2, "FADE");

            List<_2FAR_Library.Promo> promo = new List<_2FAR_Library.Promo>();
            promo.Add(promo1);
            promo.Add(promo2);
            promo.Add(promo3);

            List<string> promo_string = new List<string>();

            foreach (var item in promo)
            {
                promo_string.Add(item.nomPromo);
            }
            cbb_promo.ItemsSource = promo_string;
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
            return AdoUtilisateur.getAdoUtilisateur().Where(Utilisateur =>
                Utilisateur.nomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
                Utilisateur.prenomUtilisateur.ToLower().Contains(texteRecherche.ToLower()) ||
                Utilisateur.mailUtilisateur.ToLower().Contains(texteRecherche.ToLower()))
                .ToList();
        }
    }
}
