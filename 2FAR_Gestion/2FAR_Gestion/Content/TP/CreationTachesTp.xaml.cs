using _2FAR_Library;
using System.Windows.Controls;
using _2FAR_Library.Graphique;
using System;
using System.Windows;

namespace _2FAR_Gestion.Content.TP
{
    /// <summary>
    /// Logique d'interaction pour CreationTachesTp.xaml
    /// </summary>
    public partial class CreationTachesTp : Page
    {
        public CreationTachesTp()
        {

            InitializeComponent();
            stack_form.Children.Add(new Form_taches());

        }

   

        public void create_taches(object o, EventArgs e) 
        { 
        
        }

        private void add_form(object sender, RoutedEventArgs e)
        {
            stack_form.Children.Add(new Form_taches());

        }
    }
}
