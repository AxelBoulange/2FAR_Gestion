using System.Net.Mime;
using _2FAR_Gestion.Content.Eleve;
using _2FAR_Gestion.Content;
using System.Windows;
using _2FAR_Gestion.Content.TP;
using _2FAR_Library.Ado;
using _2FAR_Library;
using System.Linq;
using System.Collections.Generic;
using System;

namespace _2FAR_Gestion
{
    public partial class CreationTp
    {
        public CreationTp()
        {
            InitializeComponent();

            List<string> promo_string = new List<string>();
            foreach (var item in Ados.listePromotions)
            {
                promo_string.Add(item.nomPromo);
            }
            cbb_promo_tp.ItemsSource = promo_string;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string date;

            if (string.IsNullOrWhiteSpace(tbx_nom_tp.Text) || string.IsNullOrWhiteSpace(tbx_description_tp.Text) || string.IsNullOrWhiteSpace(cbb_promo_tp.Text) || cbb_promo_tp.SelectedItem == null || dtp_date.SelectedDate < DateTime.Now )
            {
                MessageBox.Show("Erreur, tout les champs sont obligatoire", "Vérification", MessageBoxButton.OK);
            }
            else
            {
                _2FAR_Library.Promo promoEleve = null;
                foreach (var p in Ados.listePromotions.ToList())
                {
                    if (cbb_promo_tp.Text == p.nomPromo)
                    {
                        promoEleve = p; 
                    }
                    if (promoEleve == null)
                    {
                        MessageBox.Show("Erreur, la promo n'existe pas", "Vérification", MessageBoxButton.OK);

                    }
                }
                date = dtp_date.SelectedDate.ToString();
                
                Ados.listeTP.Add(new TP(Ados.listeTP.Last().idTP + 1, tbx_nom_tp.Text, tbx_description_tp.Text));
                Ados.listeAttributions.Add(new AttribuerTP(date, true, Ados.listeTP.Last(), promoEleve));

                Application.Current.MainWindow.Content = new MenuNavbar(new CreationTachesTp());
            }

        }
    }


 }
