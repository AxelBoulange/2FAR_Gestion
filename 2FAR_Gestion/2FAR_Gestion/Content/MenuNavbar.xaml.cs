using System.Windows.Controls;
using _2FAR_Library.Graphique;
using _2FAR_Library;

namespace _2FAR_Gestion.Content
{
    /// <summary>
    /// Logique d'interaction pour FrameContent.xaml
    /// </summary>
    public partial class MenuNavbar
    {
        public MenuNavbar( Page contentPage)
        {
            InitializeComponent();
            this.frameGrid.Children.Add(new NavBar(CreateTP, ListTP, VoirEleve, VoirPromos, DemandeValidation));
            this.frameContent.Content = contentPage;
        }


        private void CreateTP()
    {

        this.frameContent.Content = new CreationTp();
    }
    private void ListTP()
    {
        this.frameContent.Content = new ListeTp();
    }
    private void VoirEleve()
    {
        this.frameContent.Content = new ListeEleves();
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
