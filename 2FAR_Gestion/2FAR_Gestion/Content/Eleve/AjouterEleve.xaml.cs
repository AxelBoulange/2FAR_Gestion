using System.Collections.Generic;
using System.Linq;
using System.Windows;
using _2FAR_Library;

namespace _2FAR_Gestion.Content.Eleve
{
    public partial class AjouterEleve
    {
        public AjouterEleve()
        {
            InitializeComponent();
            List<string> nomPromo = new List<string>();
            foreach (var p in Ados.listePromotions)
            {
               nomPromo.Add(p.nomPromo);
            }
            cbb_promo.ItemsSource = nomPromo;
            if (cbb_promo.Items != null)
                cbb_promo.SelectedItem = cbb_promo.Items[0];
            else
                MessageBox.Show("Il n'y a pas de promotion, vous ne pourrez pas créé d'éléves", "Vérification", MessageBoxButton.OK);

        }

        private void Valider_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_nom.Text) || string.IsNullOrWhiteSpace(tbx_prenom.Text) || string.IsNullOrWhiteSpace(tbx_mail.Text) || string.IsNullOrWhiteSpace(tbx_mdp.Text) || string.IsNullOrWhiteSpace(cbb_promo.Text) || cbb_promo.SelectedItem == null)
            {
                MessageBox.Show("Erreur, tout les champs sont obligatoire", "Vérification", MessageBoxButton.OK);
            }
            else
            { 
                if (cbb_promo.SelectedItem != null && !string.IsNullOrEmpty(cbb_promo.Text))
                {
                    _2FAR_Library.Promo promoEleve = null;
                    foreach (var p in Ados.listePromotions)
                        if (p.nomPromo == cbb_promo.Text)
                            promoEleve = p;
                    if (promoEleve == null)
                        MessageBox.Show("Erreur, la promo n'existe pas", "Vérification", MessageBoxButton.OK);
                    else
                        Ados.listeUtilisateurs.Add(new Utilisateur(Ados.listeUtilisateurs.Count == 0? 1: Ados.listeUtilisateurs.Last().idUtilisateur + 1 , tbx_nom.Text, tbx_prenom.Text, tbx_mail.Text, tbx_mdp.Text, false, promoEleve.idPromo, promoEleve.nomPromo));
                }
                else
                {
                    MessageBox.Show("Erreur, Promotion Invalide", "Vérification", MessageBoxButton.OK);
                }
            }
        }
    }
}
