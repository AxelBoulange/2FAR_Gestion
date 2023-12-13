using System.Net.Mime;
using _2FAR_Gestion.Content.Eleve;
using _2FAR_Gestion.Content;
using System.Windows;
using _2FAR_Gestion.Content.TP;

namespace _2FAR_Gestion
{
    public partial class CreationTp
    {
        public CreationTp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new MenuNavbar(new CreationTachesTp());
                
        }
    }


 }
