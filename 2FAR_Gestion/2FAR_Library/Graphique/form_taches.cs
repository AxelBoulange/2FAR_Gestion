using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using _2FAR_Library.Graphique;
using System.Reflection.Metadata;
using MahApps.Metro.Controls;

namespace _2FAR_Library
{
    public class Form_taches : Grid
    {
        public Form_taches() 
        {   
            this.Background = (new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb")));
            this.HorizontalAlignment = HorizontalAlignment.Center;
            this.Margin = new Thickness(0,0,0,40);


            // ... le reste du cod
            for (int i = 0; i < 8; i++) //faire 8 lignes
            {
                this.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
            }

            for (int i = 0; i < 3; i++) //faire 3 colonnes
            {
                this.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            Label titre_ordre = new Label();
            titre_ordre.Content = "ordre";
            titre_ordre.HorizontalAlignment = HorizontalAlignment.Center;
            titre_ordre.FontSize = 12;
            titre_ordre.Foreground = Brushes.White;
            titre_ordre.FontWeight = FontWeights.Bold;

            Grid.SetColumn(titre_ordre, 0);
            Grid.SetRow(titre_ordre, 1);
            this.Children.Add(titre_ordre);
            


            TextBox tbx_ordre = new TextBox();
            tbx_ordre.Margin = new Thickness(15,15,0,5);

            Grid.SetColumn(tbx_ordre, 0);
            Grid.SetRow(tbx_ordre, 2);
            this.Children.Add(tbx_ordre);



            Label titre_intitule = new Label();
            titre_intitule.Content = "Intitulé";
            titre_intitule.HorizontalAlignment = HorizontalAlignment.Center;
            titre_intitule.FontSize = 12;
            titre_intitule.Foreground = Brushes.White;
            titre_intitule.FontWeight = FontWeights.Bold;


            Grid.SetColumn(titre_intitule, 0);
            Grid.SetRow(titre_intitule, 3);
            this.Children.Add(titre_intitule);



            TextBox tbx_intitule = new TextBox();
            tbx_intitule.Margin = new Thickness(15, 5, 15, 5);
            tbx_intitule.MinWidth = 350;
            tbx_intitule.MinWidth = 900;


            Grid.SetColumn(tbx_intitule, 0);
            Grid.SetRow(tbx_intitule, 4);
            Grid.SetColumnSpan(tbx_intitule, 3);
            this.Children.Add(tbx_intitule);



            Label titre_point = new Label();
            titre_point.Content = "Points";
            titre_point.HorizontalAlignment = HorizontalAlignment.Center;
            titre_point.FontSize = 12;
            titre_point.Foreground = Brushes.White;
            titre_point.FontWeight = FontWeights.Bold;

            Grid.SetColumn(titre_point, 0);
            Grid.SetRow(titre_point, 5);
            this.Children.Add(titre_point);



            TextBox tbx_point = new TextBox();
            tbx_point.Margin = new Thickness(15, 5, 0, 20);

            Grid.SetColumn(tbx_point, 0);
            Grid.SetRow(tbx_point, 6);
            this.Children.Add(tbx_point);



            Label titre_checkpoint = new Label();
            titre_checkpoint.Content = "Checkpoints";
            titre_checkpoint.HorizontalAlignment = HorizontalAlignment.Center;
            titre_checkpoint.FontSize = 12;
            titre_checkpoint.Foreground = Brushes.White;
            titre_checkpoint.FontWeight = FontWeights.Bold;

            Grid.SetColumn(titre_checkpoint, 1);
            Grid.SetRow(titre_checkpoint, 5);
            this.Children.Add(titre_checkpoint);

            CheckBox ckb_checkpoint = new CheckBox();
            ckb_checkpoint.HorizontalAlignment = HorizontalAlignment.Center;
            ckb_checkpoint.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(ckb_checkpoint, 1);
            Grid.SetRow(ckb_checkpoint, 6);
            this.Children.Add(ckb_checkpoint);



            Label titre_bonus = new Label();
            titre_bonus.Content = "Bonus";
            titre_bonus.HorizontalAlignment = HorizontalAlignment.Center;
            titre_bonus.FontSize = 12;
            titre_bonus.Foreground = Brushes.White;
            titre_bonus.FontWeight = FontWeights.Bold;

            Grid.SetColumn(titre_bonus, 2);
            Grid.SetRow(titre_bonus, 5);
            this.Children.Add(titre_bonus);

            CheckBox ckb_bonus = new CheckBox();
            ckb_bonus.HorizontalAlignment = HorizontalAlignment.Center;
            ckb_bonus.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(ckb_bonus, 2);
            Grid.SetRow(ckb_bonus, 6);
            this.Children.Add(ckb_bonus);



            //StackPanel intitule = new StackPanel();
            //intitule.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5e17eb"));
            //intitule.HorizontalAlignment = HorizontalAlignment.Stretch;
            //intitule.VerticalAlignment = VerticalAlignment.Center;



            //TextBox tbx_intitule = new TextBox();
            //tbx_intitule.HorizontalAlignment = HorizontalAlignment.Stretch;
            //tbx_intitule.Height = 80;
            //tbx_intitule.Width = 600;

            //intitule.Children.Add(titre_intitule);
            //intitule.Children.Add(tbx_intitule);
            //ordre.Margin = new Thickness(2);

            //Grid.SetColumn(intitule, 0);
            //Grid.SetRow(intitule, 1);
            //this.Children.Add(intitule);


        }

 

    }
}
