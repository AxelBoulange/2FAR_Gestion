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
using _2FAR_Library.Graphique;

namespace _2FAR_Gestion.Content
{
    /// <summary>
    /// Logique d'interaction pour FrameContent.xaml
    /// </summary>
    public partial class FrameContent : Page
    {
        public FrameContent( Page contentPage)
        {
            InitializeComponent();
            this.frameGrid.Children.Add(new NavBar(CreateTP, ListTP, VoirEleve, VoirPromos, DemandeValidation));
            this.frameContent.Content = contentPage;

        }


        private void CreateTP()
    {

        this.frameContent.Content = new CreationTP();
    }
    private void ListTP()
    {
        this.frameContent.Content = new ListeTp();
    }
    private void VoirEleve()
    {
        this.frameContent.Content = new VoirEleve();
    }
    private void VoirPromos()
    {
        this.frameContent.Content = new VoirPromos();
    }
    private void DemandeValidation()
    {
        this.frameContent.Content = new DemandeValidation();
    }
}
}
