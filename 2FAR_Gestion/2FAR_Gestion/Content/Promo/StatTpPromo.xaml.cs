using System.Windows.Controls;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace _2FAR_Gestion.Content.Promo;


public partial class StatTpPromo : Page
{
    public ISeries[] Series { get; set; }
    public StatTpPromo()
    {
        Series = new ISeries[]
        {
            new ColumnSeries<int>
            {
                Values = new []{ 2, 5, 4, 2, 6 },
                Name = "Income", 
                Stroke = null
            },
            new ColumnSeries<int>
            {
                Values = new []{ 3, 7, 2, 9, 4 },
                Name = "Outcome", 
                Stroke = null
            }
        };
        InitializeComponent();
    }
}

