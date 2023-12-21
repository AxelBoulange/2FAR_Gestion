using System.Windows;
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
            this.grd_Menu.Children.Add(new NavBar(CreerTP, ListeTP, ListeEleve, ListePromos, ListeDemandeValidation));
            this.frm_Page.Content = contentPage;
        }
        
        private void CreerTP()
        {
            this.frm_Page.Content = new CreationModificationTp();
        }
        private void ListeTP()
        {
            this.frm_Page.Content = new ListeTp();
        }
        private void ListeEleve()
        {
            this.frm_Page.Content = new ListeEleves();
        }
        private void ListePromos()
        {
            this.frm_Page.Content = new ListePromos();
        }
        private void ListeDemandeValidation()
        {
            this.frm_Page.Content = new DemandeValidation();
        }
    }
}
