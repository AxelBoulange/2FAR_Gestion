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
            InitializeComponent();
            listCartes.Children.Add(new Carte("bts SIO 2", "Classe de bts sio 2"));
            Margin = new Thickness(0, 0, 50, 0);
            listCartes.Children.Add(new Carte("bts SIO 1", "Classe de bts sio 1"));
        }
    }
}
