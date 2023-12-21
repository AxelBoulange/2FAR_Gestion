﻿using _2FAR_Library;
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
            stack_form.Children.Add(new Form_taches());

        }

   

        public void create_taches(object o, EventArgs e) 
        {
            foreach (Form_taches t in stack_form.Children)
            {
                t.GetFieldValues(t.GetCkb_bonus());

                t.ChampsComplet(t.ordre , t.intitule, t.desc, t.points);

                if (t.valide == true)
                {
                    Ados.listeTaches.Add(new Tache(Ados.listeTaches.Last().idTache + 1, t.desc, t.checkpoint, t.ordre, t.points, t.bonus, true, tp.idTP, t.intitule ));
                    tp.tacheList.Add(Ados.listeTaches.Last());
                    foreach (_2FAR_Library.AttribuerTP attribuer in Ados.listeAttributions )
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

                                    }
                                }
                            }
                        }
                            MessageBoxResult result = MessageBox.Show("Créations validé", "Vérification", MessageBoxButton.OK);
                    }
                }
                else {
                    MessageBoxResult result = MessageBox.Show("Erreur, les champs ne sont pas remplis ou ne respecte pas les conditions", "Vérification", MessageBoxButton.OKCancel);


                };
            }
        }

        private void add_form(object sender, RoutedEventArgs e)
        {
            stack_form.Children.Add(new Form_taches());

        }
    }
}
