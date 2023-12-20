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

namespace _2FAR_Gestion.Content.Promo
{
    /// <summary>
    /// Logique d'interaction pour ActionPromos.xaml
    /// </summary>
    public partial class CreationModificationPromo : Page
    {
        public string oldName { get; set; } = String.Empty;

        public CreationModificationPromo()
        {
            loading("ajouter une promo");
        }

        public CreationModificationPromo(_2FAR_Library.Promo p)
        {

            loading("Modifier une promo");
            oldName = p.nomPromo;
            tbx_nomPromo.Text = p.nomPromo;

        }



        void loading(string title)
        {
            InitializeComponent();

            lb_title.Content = title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //vérifier que l'entrée utilisateur est valide
            if (string.IsNullOrEmpty(tbx_nomPromo.Text))
            {
                //si entrée vide, l'indique à l'aide d'une messageBox
                MessageBox.Show("Veuillez remplir un nom avant d'ajouter");
            }
            else
            {
                if (oldName != string.Empty && tbx_nomPromo.Text == oldName)
                {
                    MessageBox.Show("Cette promotion existe déjà.");
                }
                else
                {
                    Ados.listePromotions.Add(new _2FAR_Library.Promo(Ados.listePromotions.Where(p => p.nomPromo == oldName).First().idPromo, tbx_nomPromo.Text));
                    Ados.listePromotions.Remove(Ados.listePromotions.Where(p => p.nomPromo == oldName).First());
                    Application.Current.MainWindow.Content = new ListePromos();
                }
            }
        }
    }
}

