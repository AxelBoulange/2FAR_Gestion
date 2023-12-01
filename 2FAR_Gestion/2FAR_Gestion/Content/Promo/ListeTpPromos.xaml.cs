using System.Collections.Generic;
using System.Linq;

namespace _2FAR_Gestion.Content.Promo;

public partial class ListeTpPromos
{
    private List<_2FAR_Library.TP> TP  {
        get;
        set;
    }

    public ListeTpPromos(_2FAR_Library.Promo promo)
    {
     //   this.TP =  MainWindow.listeTP.Where(TP => TP.idTP == MainWindow.listeAttributions.Where(etreatribuer => etreatribuer.tp.idTP == TP.idTP)).ToList();
     //   InitializeComponent();
    }
}