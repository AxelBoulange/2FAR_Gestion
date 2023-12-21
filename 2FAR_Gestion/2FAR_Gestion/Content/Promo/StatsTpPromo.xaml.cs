using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using _2FAR_Library;

namespace _2FAR_Gestion.Content.Promo;

public partial class StatsTpPromo : Page
{
    
    public StatsTpPromo(_2FAR_Library.TP tp)
    {
        List<_2FAR_Library.Tache> tachesDuTp = new List<_2FAR_Library.Tache>();

        foreach (var tache in Ados.listeTaches)
        {
            if (tache.fk_id_tp == tp.idTP)
                tachesDuTp.Add(tache);
        }
        InitializeComponent();
        if (tachesDuTp != null)
            Scrv_Stat_Tp.Content = new StatGrid(tachesDuTp);
    }
}

public class StatGrid : Grid
{
    public StatGrid(List<_2FAR_Library.Tache> taches)
    {
        
        this.ColumnDefinitions.Add(new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) } );
        this.ColumnDefinitions.Add(new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) } );
        this.ColumnDefinitions.Add(new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) } );
        this.ColumnDefinitions.Add(new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) } );
        this.ColumnDefinitions.Add(new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) } );
        this.ColumnDefinitions.Add(new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) } );
        
        this.RowDefinitions.Add(new RowDefinition{ Height = new GridLength(1, GridUnitType.Auto)} );

        LabelToAdd lbl = new LabelToAdd("Nom", 15,true);
        Grid.SetColumn(lbl, 0);
        this.Children.Add(lbl);
        
        lbl = new LabelToAdd("0%", 15,true);
        Grid.SetColumn(lbl, 1);
        this.Children.Add(lbl);
        
        lbl = new LabelToAdd("< 50%", 15,true);
        Grid.SetColumn(lbl, 2);
        this.Children.Add(lbl);
        
        lbl = new LabelToAdd(">= 50%", 15,true);
        Grid.SetColumn(lbl, 3);
        this.Children.Add(lbl);
        
        lbl = new LabelToAdd("100%", 15,true);
        Grid.SetColumn(lbl, 4);
        this.Children.Add(lbl);
        
        lbl = new LabelToAdd("Total", 15,true);
        Grid.SetColumn(lbl, 5);
        this.Children.Add(lbl);
        int row = 2;
        foreach (var t in taches)
        {
            int pasCommence = 0;
            int infCinquante = 0;
            int supCinquante = 0;
            int finit = 0;
            
            foreach (var avancementTache in Ados.listeAvancementTaches)
            {
                if (t.fk_id_tp == avancementTache.tache.idTache)
                {
                    if (avancementTache.taux_avancement == 0)
                        pasCommence += 1;
                    
                    else if (avancementTache.taux_avancement < 50)
                        infCinquante += 1;
                    
                    else if (avancementTache.taux_avancement >= 50 && avancementTache.taux_avancement < 100)
                        supCinquante += 1;
                    
                    else
                        finit += 1;
                }
            }
            this.RowDefinitions.Add(new RowDefinition{ Height = new GridLength(1, GridUnitType.Auto) } );
            
            lbl = new LabelToAdd(t.titreTache, 13,true);
            Grid.SetColumn(lbl, 0);
            Grid.SetRow(lbl, row);
            this.Children.Add(lbl);
            
            lbl = new LabelToAdd(pasCommence.ToString(), 13,false);
            Grid.SetColumn(lbl, 1);
            Grid.SetRow(lbl, row);
            this.Children.Add(lbl);
        
            lbl = new LabelToAdd(infCinquante.ToString(), 13,false);
            Grid.SetColumn(lbl, 2);
            Grid.SetRow(lbl, row);
            this.Children.Add(lbl);
        
            lbl = new LabelToAdd(supCinquante.ToString(), 13,false);
            Grid.SetColumn(lbl, 3);
            Grid.SetRow(lbl, row);
            this.Children.Add(lbl);
        
            lbl = new LabelToAdd(finit.ToString(), 13,false);
            Grid.SetColumn(lbl, 4);
            Grid.SetRow(lbl, row);
            this.Children.Add(lbl);
        
            lbl = new LabelToAdd((pasCommence+infCinquante+supCinquante+finit).ToString(), 13, false);
            Grid.SetColumn(lbl, 5);
            Grid.SetRow(lbl, row);
            this.Children.Add(lbl);

            row += 1;
        }
    }
}

public class LabelToAdd : Label
{
    public LabelToAdd(string text, double size, bool isbold)
    {
        Content = text;
        FontSize = size;
        HorizontalContentAlignment = HorizontalAlignment.Center;
        HorizontalAlignment = HorizontalAlignment.Center;
        VerticalContentAlignment = VerticalAlignment.Center;
        VerticalAlignment = VerticalAlignment.Center;

        Padding = new Thickness(7, 7, 7, 7);
        
        if (isbold)
        {
            FontWeight = FontWeights.Bold;
        }
    }
}