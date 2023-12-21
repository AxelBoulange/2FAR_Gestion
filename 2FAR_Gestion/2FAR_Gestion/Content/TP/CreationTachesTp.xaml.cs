using _2FAR_Library;
using System.Windows.Controls;
using _2FAR_Library.Graphique;
using System;
using System.Windows;
using System.Linq;
using System.Collections.Generic;

namespace _2FAR_Gestion.Content.TP
{
    /// <summary>
    /// Logique d'interaction pour CreationTachesTp.xaml
    /// </summary>
    public partial class CreationTachesTp : Page
    {
        _2FAR_Library.TP tp;
        public CreationTachesTp(_2FAR_Library.TP letp)
        {
            tp = letp;

            InitializeComponent();
            stp_tache.Children.Add(new Form_taches());

        }

   

        public void create_taches(object o, EventArgs e) 
        {
            bool valide = false;
            
            foreach (Form_taches t in stp_tache.Children)
            {
                t.GetFieldValues(t.GetCkb_bonus());

                t.ChampsComplet(t.ordre , t.intitule, t.desc, t.points);

                if (t.valide == true)
                {
                    Ados.listeTaches.Add(new _2FAR_Library.Tache(Ados.listeTaches.Last().idTache + 1, t.desc, t.checkpoint, t.ordre, t.points, t.bonus, true, tp.idTP, t.intitule ));
                    tp.tachesListe.Add(Ados.listeTaches.Last());
                    foreach (_2FAR_Library.TPAttribuer attribuer in Ados.listeAttributions )
                    {
                        if (attribuer.tp == tp)
                        {
                            foreach (_2FAR_Library.Promo p in Ados.listePromotions)
                            {
                                if (attribuer.promotion == p)
                                {
                                    foreach (_2FAR_Library.Utilisateur u in p.utilisateurList)
                                    {
                                        Ados.listeAvancementTaches.Add(new AvancementTache(0, Ados.listeTaches.Last(), u));
                                        valide = true;
                                    }
                                }
                            }
                        }
                    }
                    
                }
                else {
                    MessageBoxResult result = MessageBox.Show("Erreur, les champs ne sont pas remplis ou ne respecte pas les conditions", "Vérification", MessageBoxButton.OKCancel);
                    break;

                };
            }
            if (valide == true)
            {
                MessageBoxResult result = MessageBox.Show("Créations validé", "Vérification", MessageBoxButton.OK);
                if (result == MessageBoxResult.OK) {Application.Current.MainWindow.Content = new MenuNavbar(new ListeTp());
                }
            }
        }

        private void add_form(object sender, RoutedEventArgs e)
        {
            stp_tache.Children.Add(new Form_taches());

        }
    }
}
