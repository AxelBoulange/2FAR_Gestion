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
using _2FAR_Library;

namespace _2FAR_Gestion
{
    public partial class VoirEleve : Page
    {
        public VoirEleve()
        {
            InitializeComponent();
            cbb_promo.Items.Add("Promo");
            cbb_promo.SelectedItem = "Promo";

        }


        public void titrePromo(object sender, EventArgs e)
        {
                cbb_promo.Items.Remove("Promo");
        }        

    }
}
