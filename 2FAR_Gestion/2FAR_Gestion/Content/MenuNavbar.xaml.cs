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
        MainWindow page;
        public MenuNavbar( Page contentPage, MainWindow page)
        {
            InitializeComponent();
            this.frameGrid.Children.Add(new NavBar(CreateTP, ListTP, VoirEleve, VoirPromos, DemandeValidation));
            this.frameContent.Content = contentPage;
            this.page = page;
        }


        private void CreateTP()
    {

        this.frameContent.Content = new CreationTp();
    }
    private void ListTP()
    {
        this.frameContent.Content = new ListeTp(page);
    }
    private void VoirEleve()
    {
        this.frameContent.Content = new VoirEleves(page);
    }
    private void VoirPromos()
    {
        this.frameContent.Content = new VoirPromos(page);
    }
    private void DemandeValidation()
    {
        this.frameContent.Content = new DemandeValidation();
    }
}
}
