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

namespace _2FAR_Gestion.Content.TP
{
    /// <summary>
    /// Logique d'interaction pour VoirTp.xaml
    /// </summary>
    public partial class VoirTp : Page
    {
        _2FAR_Library.TP tp;
        public VoirTp(_2FAR_Library.TP letp)
        {
            tp = letp;
            InitializeComponent();
        }
    }
}
