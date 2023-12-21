using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using _2FAR_Library;
using _2FAR_Library.Graphique;

namespace _2FAR_Gestion.Content.Promo;

public partial class ListeTpPromos
{
    public ListeTpPromos(_2FAR_Library.Promo promo)
    {
        InitializeComponent();
        foreach (var attribuerTp in Ados.listeAttributions)
            if (attribuerTp.promotion.idPromo == promo.idPromo)
                stp_liste_tp.Children.Add(new Carte(attribuerTp.tp.nomTP, attribuerTp.tp.descriptionTP, new Dictionary<string, Action<object, EventArgs>>{{"Statistiques",statistiques},{"Modifier",modifier}},20,15,attribuerTp.tp));
    }

    private void statistiques(object o, EventArgs e)
    {
        if (o is Btn b && b.Parent is StackPanel s && s.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.TP tp)
        {
            Application.Current.MainWindow.Content = new MenuNavbar(new StatsTpPromo(tp));
        }
    }
    private void modifier(object o, EventArgs e)
    {
        if (o is Btn b && b.Parent is StackPanel s && s.Parent is Grid g && g.Parent is Carte c && c.objectCarte is _2FAR_Library.TP tp)
        {
            Application.Current.MainWindow.Content = new MenuNavbar(new CreationModificationTp(Ados.listeAttributions.Where(at => at.tp.idTP == tp.idTP).First()));
        }
    }
}