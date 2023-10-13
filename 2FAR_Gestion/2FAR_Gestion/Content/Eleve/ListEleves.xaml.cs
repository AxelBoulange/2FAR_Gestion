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

namespace _2FAR_Gestion
{
    public partial class VoirEleve : Page
    {
        public VoirEleve()
        {
            InitializeComponent();
            cbb_promo.Items.Add("Promo");
            cbb_promo.SelectedItem = "Promo";



            _2FAR_Library.Utilisateur user = new _2FAR_Library.Utilisateur(0, "test", "alala", "mail@mail.fr", "azerty39", true);
            _2FAR_Library.Utilisateur user1 = new _2FAR_Library.Utilisateur(0, "test", "alala", "mail@mail.fr", "azerty39", true);
            _2FAR_Library.Utilisateur user2 = new _2FAR_Library.Utilisateur(0, "test", "alala", "mail@mail.fr", "azerty39", true);
            _2FAR_Library.Utilisateur user3 = new _2FAR_Library.Utilisateur(0, "test", "alala", "mail@mail.fr", "azerty39", true);
            _2FAR_Library.Utilisateur user4 = new _2FAR_Library.Utilisateur(0, "test", "alala", "mail@mail.fr", "azerty39", true);

            List<_2FAR_Library.Utilisateur> collection = new List<_2FAR_Library.Utilisateur>();
            collection.Add(user);
            collection.Add(user1);
            collection.Add(user2);
            collection.Add(user3);
            collection.Add(user4);

            //datagrid.Items.Add(collection);
            datagrid.ItemsSource = collection;

        }


        public void titrePromo(object sender, EventArgs e)
        {
                cbb_promo.Items.Remove("Promo");
        }        

    }
}
