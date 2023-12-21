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
    public partial class CreationModificationTp
    {
        private TPAttribuer TPAttribuer { get; set; } = null;
        public CreationModificationTp()
        {
            InitializeComponent();
            
            List<string> promo_string = new List<string>();
            foreach (var item in Ados.listePromotions)
            {
                promo_string.Add(item.nomPromo);
            }
            cbb_promo_tp.ItemsSource = promo_string;


        }
        
        public CreationModificationTp(_2FAR_Library.TPAttribuer TPAttribuer)
        {

            this.TPAttribuer = TPAttribuer;
            
            InitializeComponent();
            btn_Validation.Content = " Valider la Modification du TP";

            List<string> promo_string = new List<string>();
            foreach (var item in Ados.listePromotions)
            {
                promo_string.Add(item.nomPromo);
            }
            cbb_promo_tp.ItemsSource = promo_string;
            
            tbx_nom_tp.Text = TPAttribuer.tp.nomTP;
            tbx_description_tp.Text = TPAttribuer.tp.descriptionTP;

            if (promo_string.Contains(TPAttribuer.promotion.nomPromo))
            {
                cbb_promo_tp.SelectedItem = TPAttribuer.promotion.nomPromo;
            }

            if (TPAttribuer.dte_fin.HasValue)
            {
                dtp_date.SelectedDate = TPAttribuer.dte_fin.Value;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date;

            if (string.IsNullOrWhiteSpace(tbx_nom_tp.Text) || string.IsNullOrWhiteSpace(tbx_description_tp.Text) || string.IsNullOrWhiteSpace(cbb_promo_tp.Text) || cbb_promo_tp.SelectedItem == null || /*dtp_date.SelectedDate < DateTime.Now ||*/ dtp_date.SelectedDate == null)
            {
                MessageBox.Show("Erreur, tout les champs sont obligatoire", "Vérification", MessageBoxButton.OK);
            }
            else
            {
                _2FAR_Library.Promo promoEleve = null;
                foreach (var p in Ados.listePromotions)
                {
                    if (cbb_promo_tp.Text == p.nomPromo)
                    {
                        promoEleve = p; 
                    }
                }
                if (promoEleve == null)
                {
                    MessageBox.Show("Erreur, la promo n'existe pas", "Vérification", MessageBoxButton.OK);
                }
                else
                {
                    date = (DateTime)dtp_date.SelectedDate;
                    if (TPAttribuer != null)
                    {
                        Ados.listeTP.Remove(Ados.listeTP.Where(Tp => Tp.idTP == TPAttribuer.tp.idTP).First());
                        Ados.listeTP.Add(new TP(TPAttribuer.tp.idTP, tbx_nom_tp.Text, tbx_description_tp.Text));
                        if (cbb_promo_tp.SelectedItem != TPAttribuer.promotion.nomPromo)
                        {
                            Ados.listeAttributions.Remove(Ados.listeAttributions.Where(at =>
                                at.promotion.nomPromo == TPAttribuer.promotion.nomPromo &&
                                at.tp.idTP == TPAttribuer.tp.idTP).First());
                            Ados.listeAttributions.Add(new TPAttribuer(dtp_date.SelectedDate.Value, TPAttribuer.is_actif, Ados.listeTP.Where(Tp => Tp.idTP == TPAttribuer.tp.idTP).First(),Ados.listePromotions.Where(Promo => Promo.nomPromo == cbb_promo_tp.SelectedItem).First() ));
                            Application.Current.MainWindow.Content = new PageAccueil();
                        }
                    }
                    else
                    {
                        Ados.listeTP.Add(new TP(Ados.listeTP.Last().idTP + 1, tbx_nom_tp.Text, tbx_description_tp.Text));
                        Ados.listeAttributions.Add(new TPAttribuer(date, true, Ados.listeTP.Last(), promoEleve));
                    }
                    Application.Current.MainWindow.Content = new MenuNavbar(new CreationTachesTp(Ados.listeTP.Last()));
                }
            }
        }
    }
 }
