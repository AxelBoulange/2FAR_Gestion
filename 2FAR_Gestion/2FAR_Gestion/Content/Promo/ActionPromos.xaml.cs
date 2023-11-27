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
        string action;
        _2FAR_Library.Promo promo;
        public ActionPromos(int promo)
        {
            loading("Modifier une promo");
            foreach (_2FAR_Library.Promo p in MainWindow.listePromotions)
            {
                  if (p.idPromo == promo)
                {
                    _2FAR_Library.Promo prom = p;
                    lb_test.Content = prom.nomPromo;

                }
            }
            
        }

        public ActionPromos() 
        {
            loading("Ajouter une promo");
        }

        void loading(string title)
        {
            InitializeComponent();

            lb_title.Content = title;
        }
    }
}
