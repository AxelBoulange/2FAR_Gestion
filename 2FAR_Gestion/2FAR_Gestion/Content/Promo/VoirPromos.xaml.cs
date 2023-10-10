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
    public partial class VoirPromos : Page
    {
        public VoirPromos()
        {
            List<Action> actionsButton = new List<Action>() { consulter, modifier, supprimer};
            //actionsButton.Add("voir");
            //actionsButton.Add("consulter");
            //actionsButton.Add("supprimer");
            InitializeComponent();
            this.listCartes.Children.Add(new Carte("BTS", "Bts2", actionsButton));
            this.listCartes.Children.Add(new Carte("BTS", "Bts1", consulter));
            this.listCartes.Children.Add(new Carte("BTSsio", "BtsSIO", actionsButton));


            //listCartes.Children.Add(new Carte("bts SIO 1", "Classe de bts sio 1"));
        }

        private void consulter()
        {
            //List<Action> actionsButton = new List<Action>() { voir, supprimer, ajouter };
            //this.listCartes.Children.Add(new Carte("btssssssgbhnj,k;ssss", "bGHJK?NBVGHJ", actionButton);
        }
        private void modifier()
        {
           this.listCartes.Children.Clear();
        }

        private void supprimer()
        {

        }
    }
}
