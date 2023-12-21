using System;
using System.Collections.Generic;
using System.Windows;
using _2FAR_Library;
using _2FAR_Gestion.Content;
using _2FAR_Gestion.Content.TP;
using _2FAR_Gestion.Content.Tache;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Linq;

namespace _2FAR_Gestion.Content.Tache
{
    public partial class ListeTaches
    {
        _2FAR_Library.TP leTP = null;
        public ListeTaches(_2FAR_Library.TP tp)
        {
            leTP = tp;
            InitializeComponent();

            if(tp.tachesListe !=  null)
            {
                foreach(var tache in tp.tachesListe)
                {
                    this.stp_liste_tache.Children.Add(new Carte(tache.titreTache, tache.descriptionTache, new Dictionary<string, Action<object, EventArgs>> { { "Supprimer", supprimer } }, 15, 14, tache));
                }
            }
            else
            {
                MessageBox.Show("Il n'y à pas de taches dans ce tp", "Vérification", MessageBoxButton.OK);
            }
        }
        private void supprimer(object o, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette tâche ?", "Vérification", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.Tache tache)
                {

                    var taches = Ados.listeTP.Where(tp => tp.idTP == leTP.idTP).First().tachesListe;
                    taches.Remove(taches.Where(t => t.idTache == tache.idTache).First());
                    Ados.listeTP.Where(tp => tp.idTP == leTP.idTP).First().tachesListe = taches;

                    Ados.listeTaches.Remove(Ados.listeTaches.Where(t => t.idTache == tache.idTache).First());


                    Application.Current.MainWindow.Content = new MenuNavbar(new ListeTaches(leTP));
                }
            }
        }
    }
 
}
