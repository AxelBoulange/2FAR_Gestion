﻿using System.Windows.Controls;
using _2FAR_Library.Graphique;

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

        this.frameContent.Content = new CreationTP();
    }
    private void ListTP()
    {
        this.frameContent.Content = new ListeTp();
    }
    private void VoirEleve()
    {
        this.frameContent.Content = new VoirEleves(page);
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
