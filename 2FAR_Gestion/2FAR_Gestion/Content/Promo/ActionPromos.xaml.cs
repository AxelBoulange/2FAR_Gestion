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
    }
}
