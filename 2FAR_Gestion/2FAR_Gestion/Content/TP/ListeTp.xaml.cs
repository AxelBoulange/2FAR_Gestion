﻿using System;
using System.Collections.Generic;
using System.Windows;
using _2FAR_Library;
using _2FAR_Gestion.Content;
using _2FAR_Gestion.Content.Promo;

namespace _2FAR_Gestion
{
    public partial class ListeTp
    {
        public ListeTp()
        {
            Dictionary<string,Action<object, EventArgs>> actionsButton = new Dictionary<string,Action<object, EventArgs>> { {"consulter",consulter},{"modifier",modifier},{"supprimer",supprimer}};
            
            InitializeComponent();

            foreach (var tp in Ados.listeTP)
            {
                int count = 0;
                foreach (var tache in Ados.listeTaches)
                {
                    if (tache.fk_id_tp == tp.idTP)
                    {
                        count++;
                    }
                }
                this.listCartes.Children.Add(new Carte("nom du TP :"+ tp.nomTP + "\n nombre de tache :" + count , tp.descriptionTP, actionsButton, 15, 14, tp));
            }
        }
        private void consulter(object o, EventArgs e)
        {
            
        }
        private void modifier(object o, EventArgs e)
        {
            this.listCartes.Children.Clear();
        }

        private void supprimer(object o, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Étes-Vous sur de vouloir supprimer cette promo", "Vérification", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                
            }
            else if (result == MessageBoxResult.Cancel)
            {
                
            }
            else
            {
                //impossible mais oklm
                MessageBox.Show("Erreur Inconnue");
            }
        }

        private void add_tp(object sender, EventArgs e)
        {
            Application.Current.MainWindow.Content = new MenuNavbar(new CreationTp());
        }
    }
}
