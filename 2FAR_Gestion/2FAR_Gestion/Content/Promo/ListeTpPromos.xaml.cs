using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Windows;
using System.Windows.Documents;
using _2FAR_Library;

namespace _2FAR_Gestion.Content.Promo;

public partial class ListeTpPromos
{
    public ListeTpPromos(_2FAR_Library.Promo promo)
    {
        InitializeComponent();
        foreach (var attribuerTp in Ados.listeAttributions)
            if (attribuerTp.promotion.idPromo == promo.idPromo)
                listCartes.Children.Add(new Carte(attribuerTp.tp.nomTP, attribuerTp.tp.descriptionTP, new Dictionary<string, Action<object, EventArgs>>{{"consulter",consulter}},20,15,null));
    }

    private void consulter(object o, EventArgs e)
    {
        Application.Current.MainWindow.Content = new MenuNavbar(new CreationTp());
    }
}