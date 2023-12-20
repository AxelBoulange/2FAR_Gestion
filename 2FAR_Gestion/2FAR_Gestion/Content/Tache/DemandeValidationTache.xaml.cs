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
        public DemandeValidation()
        {
            //regardes les attentes de validation et les valider qui ont isJuste = false
            
            InitializeComponent();
            Dictionary<string,Action<object, EventArgs>> actionsButton = new Dictionary<string,Action<object, EventArgs>>() { {"Valider",Valider},{"Rejeter",Rejeter}};
            foreach (var attenteValidation in Ados.listeAttenteValidations)
            {
                listCartes.Children.Add(new Carte(attenteValidation.utilisateur.nomUtilisateur + "\n" + attenteValidation.utilisateur.nomPromo, attenteValidation.tache.titreTache, actionsButton, 25, 20, attenteValidation){Margin = new Thickness(20,10,20,10)});
            }
        }
        public void Valider(object o, EventArgs e)
        {
            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.AttendreValidation attendreValidation)
            {
                
            }
        }
        public void Rejeter(object o, EventArgs e)
        {
            if (o is _2FAR_Library.Graphique.Btn b && b.Parent is StackPanel st && st.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.AttendreValidation attendreValidation)
            {
                
            }
        }

    }
}
