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
    public partial class ActionPromos : Page
    {
        //_2FAR_Library.Promo prom;

        public ActionPromos()
        {
            loading("ajouter une promo");
        }
        public ActionPromos(_2FAR_Library.Promo p)
        {

            loading("Modifier une promo");
            tbx_nomPromo.Text= p.nomPromo;

        }

    

        void loading(string title)
        {
            InitializeComponent();

            lb_title.Content = title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //vérifier que l'entrée utilisateur est valide
            if(string.IsNullOrEmpty(tbx_nomPromo.Text))
            {
                //si entrée vide, l'indique à l'aide d'une messageBox
                MessageBox.Show("Veuillez remplir un nom avant d'ajouter");
            } 
            else
            {
                //si l'entrée n'est pas vide
                Boolean estDansLaListe = false;
                foreach(_2FAR_Library.Promo p in Ados.listePromotions)
                {
                    //vérifier si le nom entré est déjà dans la liste de promotions
                    if(tbx_nomPromo.Text == p.nomPromo)
                    {
                        MessageBox.Show("Cette promotion existe déjà.");
                        estDansLaListe = true;
                        break;
                    }
                }
                //si le nom entré n'est pas dans la liste, on l'ajoute à la collection de promotion
                if(!estDansLaListe)
                {
                    //on reprend le dernier id de promo, on l'incremente afin de pouvoir ajouter la nouvelle promo à la collection
                    _2FAR_Library.Promo dernierePromo = Ados.listePromotions.Last();
                    int dernierId = dernierePromo.idPromo;

                    Ados.listePromotions.Add(new _2FAR_Library.Promo(dernierId + 1, tbx_nomPromo.Text));

                    //on remet à null la text box
                    tbx_nomPromo.Text = "";
                }
                
            }

        }
    }
}
