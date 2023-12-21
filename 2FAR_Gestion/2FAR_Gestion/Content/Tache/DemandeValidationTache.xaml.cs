using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using _2FAR_Library;

namespace _2FAR_Gestion
{

    public partial class DemandeValidation
    {
        public Dictionary<string,Action<object, EventArgs>> actionsBoutton { get; set; }
        public DemandeValidation()
        {
            actionsBoutton = new Dictionary<string, Action<object, EventArgs>>() { { "Valider", Valider }, { "Rejeter", Rejeter } };
            InitializeComponent();
            AffichageListe();
        }
        public void Valider(object o, EventArgs e)
        {
            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.AttendreValidation attendreValidation)
            {
                ActionQuandBouttonClicke(attendreValidation,"Tache Validé");
            }
        }
        public void Rejeter(object o, EventArgs e)
        {
            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.AttendreValidation attendreValidation)
            {
                ActionQuandBouttonClicke(attendreValidation, "Non Validé");
            }
        }

        private void ActionQuandBouttonClicke(_2FAR_Library.AttendreValidation attendreValidation, string reponsse)
        {
            Ados.listeValidations.Add(new Valider(attendreValidation.tache, attendreValidation.utilisateur, reponsse, true));
            Ados.listeAttenteValidations.Remove(Ados.listeAttenteValidations.Where(atV => atV.utilisateur.idUtilisateur == attendreValidation.utilisateur.idUtilisateur && atV.tache.idTache == attendreValidation.tache.idTache).First());
            AffichageListe();
        }
        private void AffichageListe()
        {
            stp_liste_demande.Children.Clear();
            foreach (var attenteValidation in Ados.listeAttenteValidations)
            {
                stp_liste_demande.Children.Add(new Carte(attenteValidation.utilisateur.nomUtilisateur + "\n" + attenteValidation.utilisateur.nomPromo, attenteValidation.tache.titreTache, actionsBoutton, 25, 20, attenteValidation){Margin = new Thickness(20,10,20,10)});
            }
        }
    }
}
