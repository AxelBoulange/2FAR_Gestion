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
using System.Windows.Media.Converters;

namespace _2FAR_Library
{
    public class Form_taches : Grid
    {
        public bool valide { get; set; }
        
        private NumericUpDown nud_ordre {  get; set; }

        private TextBox tbx_intitule { get; set; }

        private TextBox tbx_desc {  get; set; }

        private NumericUpDown nud_point { get; set; }

        private CheckBox ckb_checkpoint { get; set; }

        private CheckBox ckb_bonus { get; set; }



        public int ordre { get; set; }
        public string? intitule { get; set; }
        public string? desc { get; set; }
        public int points { get; set; }
        public bool checkpoint {  get; set; }
        public bool bonus { get; set; }
        
       

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
            titre_ordre.VerticalAlignment = VerticalAlignment.Center;
            titre_ordre.FontSize = 12;
            titre_ordre.Foreground = Brushes.White;
            titre_ordre.FontWeight = FontWeights.Bold;
            Grid.SetColumn(titre_ordre, 0);
            Grid.SetRow(titre_ordre, 1);
            this.Children.Add(titre_ordre);



            


            nud_ordre = new NumericUpDown();
            nud_ordre.Margin = new Thickness(0,0,0,20);
            nud_ordre.Background = Brushes.White;
            nud_ordre.HideUpDownButtons = true;
            nud_ordre.Visibility = Visibility.Visible;
            nud_ordre.Width = 100;
            nud_ordre.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(nud_ordre, 0);
            Grid.SetRow(nud_ordre, 2);
            this.Children.Add(nud_ordre);



            Label titre_intitule = new Label();
            titre_intitule.Content = "Intitulé";
            titre_intitule.HorizontalAlignment = HorizontalAlignment.Center;
            titre_intitule.VerticalAlignment = VerticalAlignment.Center;
            titre_intitule.FontSize = 12;
            titre_intitule.Foreground = Brushes.White;
            titre_intitule.FontWeight = FontWeights.Bold;
            Grid.SetColumn(titre_intitule, 0);
            Grid.SetRow(titre_intitule, 3);
            this.Children.Add(titre_intitule);



            tbx_intitule = new TextBox();
            tbx_intitule.Margin = new Thickness(40, 0, 0, 5);
            tbx_intitule.Width = 400;
            Grid.SetColumn(tbx_intitule, 0);
            Grid.SetRow(tbx_intitule, 4);
            this.Children.Add(tbx_intitule);


            Label titre_desc = new Label();
            titre_desc.Content = "Description";
            titre_desc.HorizontalAlignment = HorizontalAlignment.Center;
            titre_desc.VerticalAlignment = VerticalAlignment.Center;
            titre_desc.FontSize = 12;
            titre_desc.Foreground = Brushes.White;
            titre_desc.FontWeight = FontWeights.Bold;
            Grid.SetColumn(titre_desc, 1);
            Grid.SetRow(titre_desc, 3);
            this.Children.Add(titre_desc);



            tbx_desc = new TextBox();
            tbx_desc.Margin = new Thickness(40, 5, 15, 5);
            tbx_desc.MinWidth = 400;
            Grid.SetColumn(tbx_desc, 1);
            Grid.SetRow(tbx_desc, 4);
            Grid.SetColumnSpan(tbx_desc, 2);
            this.Children.Add(tbx_desc);



            Label titre_point = new Label();
            titre_point.Content = "Points";
            titre_point.HorizontalAlignment = HorizontalAlignment.Center;
            titre_point.VerticalAlignment = VerticalAlignment.Center;
            titre_point.FontSize = 12;
            titre_point.Foreground = Brushes.White;
            titre_point.FontWeight = FontWeights.Bold;
            Grid.SetColumn(titre_point, 0);
            Grid.SetRow(titre_point, 5);
            this.Children.Add(titre_point);



            nud_point = new NumericUpDown();
            nud_point.Margin = new Thickness(0, 0, 0, 20);
            nud_point.Background = Brushes.White;
            nud_point.HideUpDownButtons = true;
            nud_point.Visibility = Visibility.Visible;
            nud_point.Width = 100;
            nud_point.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetColumn(nud_point, 0);
            Grid.SetRow(nud_point, 6);
            this.Children.Add(nud_point);



            Label titre_checkpoint = new Label();
            titre_checkpoint.Content = "Checkpoints";
            titre_checkpoint.HorizontalAlignment = HorizontalAlignment.Center;
            titre_checkpoint.VerticalAlignment = VerticalAlignment.Center;
            titre_checkpoint.FontSize = 12;
            titre_checkpoint.Foreground = Brushes.White;
            titre_checkpoint.FontWeight = FontWeights.Bold;
            Grid.SetColumn(titre_checkpoint, 1);
            Grid.SetRow(titre_checkpoint, 5);
            this.Children.Add(titre_checkpoint);



            ckb_checkpoint = new CheckBox();
            ckb_checkpoint.HorizontalAlignment = HorizontalAlignment.Center;
            ckb_checkpoint.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(ckb_checkpoint, 1);
            Grid.SetRow(ckb_checkpoint, 6);
            this.Children.Add(ckb_checkpoint);



            Label titre_bonus = new Label();
            titre_bonus.Content = "Bonus";
            titre_bonus.HorizontalAlignment = HorizontalAlignment.Center;
            titre_bonus.VerticalAlignment = VerticalAlignment.Center;
            titre_bonus.FontSize = 12;
            titre_bonus.Foreground = Brushes.White;
            titre_bonus.FontWeight = FontWeights.Bold;
            Grid.SetColumn(titre_bonus, 2);
            Grid.SetRow(titre_bonus, 5);
            this.Children.Add(titre_bonus);


            ckb_bonus = new CheckBox();
            ckb_bonus.HorizontalAlignment = HorizontalAlignment.Center;
            ckb_bonus.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(ckb_bonus, 2);
            Grid.SetRow(ckb_bonus, 6);
            this.Children.Add(ckb_bonus);

        }

        public CheckBox GetCkb_bonus()
        {
            return ckb_bonus;
        }

        public void GetFieldValues(CheckBox ckb_bonus)
        {
                ordre = Convert.ToInt32(nud_ordre.Value);
                intitule = tbx_intitule.Text;
                desc = tbx_desc.Text;
                points = Convert.ToInt32(nud_point.Value);
                checkpoint = Convert.ToBoolean(ckb_checkpoint.IsChecked);
                bonus = Convert.ToBoolean(ckb_bonus.IsChecked);
        }

        public Boolean ChampsComplet(double? ordre, string intitule, string desc, double? points)
        {
            if (ordre < 0 || ordre > 20  || intitule == string.Empty || intitule == null || intitule == "" || desc == string.Empty || desc == null || desc == "" || points < 0 || points >5)
            { 
                return valide = false;
            }
            else
            {
                return valide = true;
            }         
        }



    }
}
