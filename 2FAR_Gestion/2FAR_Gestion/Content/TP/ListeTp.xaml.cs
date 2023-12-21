using System;
using System.Collections.Generic;
using System.Windows;
using _2FAR_Library;
using _2FAR_Gestion.Content;
using _2FAR_Gestion.Content.Tache;
using System.Windows.Controls;
using _2FAR_Gestion.Content.TP;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

namespace _2FAR_Gestion
{
    public partial class ListeTp
    {
        public ListeTp()
        {
            Dictionary<string,Action<object, EventArgs>> actionsBoutton = new Dictionary<string,Action<object, EventArgs>> { {"Voir Les Taches",consulter},{"Modifier",modifier},{"Supprimer",supprimer}};
            
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
                this.stp_liste_tp.Children.Add(new Carte("nom du TP :"+ tp.nomTP + "\nnombre de tache :" + count , tp.descriptionTP, actionsBoutton, 15, 14, tp));
            }
        }
        private void consulter(object o, EventArgs e)
        {
            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.TP tp)
            {
                Application.Current.MainWindow.Content = new MenuNavbar(new ListTaches((TP)tp));
            }
        }
        private void modifier(object o, EventArgs e)
        {
            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.TP tp)
            {
                Application.Current.MainWindow.Content = new MenuNavbar(new CreationModificationTp(Ados.listeAttributions.Where(at => at.tp.idTP == tp.idTP).First()));
            }
        }

        private void supprimer(object o, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Étes-Vous sur de vouloir supprimer cette promo", "Vérification", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c)
                {
                    var tp = c.objectCarte;
                    var idtp = 0;

                    if (tp is _2FAR_Library.TP)
                    {

                        // Utilisation d'une boucle for inversée pour éviter les problèmes de modification de la liste
                        for (int i = Ados.listeTP.Count - 1; i >= 0; i--)
                        {
                            if (Ados.listeTP[i] == (TP)tp)
                            {
                                Ados.listeTP[i].idTP = idtp;
                                Ados.listeTP.RemoveAt(i);
                            }
                        }


                        // Utilisation d'une boucle for inversée pour éviter les problèmes de modification de la liste
                        for (int i = Ados.listeAttributions.Count - 1; i >= 0; i--)
                        {
                            var a = Ados.listeAttributions[i];

                            if (a.tp == tp)
                            {
                                Ados.listeAttributions.RemoveAt(i);
                            }
                        }


                        // Utilisation d'une boucle for inversée pour éviter les problèmes de modification de la liste
                        for (int i = Ados.listeTaches.Count - 1; i >= 0; i--)
                        {
                            var t = Ados.listeTaches[i];
                            if (t.fk_id_tp == idtp )
                            {
                                Ados.listeTaches.RemoveAt(i);
                            }
                        }

                        // Utilisation d'une boucle for inversée pour éviter les problèmes de modification de la liste
                        for (int i = Ados.listeAttenteValidations.Count - 1; i >= 0; i--)
                        {
                            var v = Ados.listeAttenteValidations[i];
                            if (v.tache.fk_id_tp == idtp)
                            {
                                Ados.listeAttenteValidations.RemoveAt(i);
                            }
                        }

                    }
                    Application.Current.MainWindow.Content = new MenuNavbar(new ListeTp());
                }
            }
        }

        private void add_tp(object sender, EventArgs e)
        {
            Application.Current.MainWindow.Content = new MenuNavbar(new CreationModificationTp());
        }
    }
}
