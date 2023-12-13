using _2FAR_Gestion.Content.Eleve;
using _2FAR_Gestion.Content;
using System.Windows;
using _2FAR_Gestion.Content.TP;

namespace _2FAR_Gestion
{
    public partial class CreationTp
    {
        private MainWindow mw;
        public CreationTp(MainWindow mw)
        {
            this.mw = mw;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mw.Content = new MenuNavbar(new CreationTachesTp(), mw);
                
        }
    }


 }
