using System;
using System.Collections.Generic;
using System.Linq;
using _2FAR_Library;

namespace _2FAR_Gestion
{

    public partial class DemandeValidation
    {
        public DemandeValidation()
        {
            InitializeComponent();
            Dictionary<string,Action> actionsButton = new Dictionary<string,Action>() { {"Valider",valider}};
            foreach (var attendreValidation in MainWindow.tpAttenteValidations)
            {
                listCartes.Children.Add(new Carte(attendreValidation.dte_demande + " | " + MainWindow.listeTP.Where(Tp => Tp.idTP == attendreValidation.tache.fk_id_tp ).First().nomTP + " | " + MainWindow.listePromotions.Where(promo => promo.idPromo == attendreValidation.utilisateur.fk_id_promo ).First().nomPromo, attendreValidation.tache.descriptionTache + " | " + attendreValidation.utilisateur.nomUtilisateur.Split().First() + " " + attendreValidation.utilisateur.prenomUtilisateur, actionsButton, 18,25));
            }
        }
        public void valider()
        {
        
        }

    }
}
