using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;



namespace _2FAR_Library
{
    public class NavBar : StackPanel
    {
        public NavBar(Action PageCreateTp, Action PageListTP, Action PageVoirEleves, Action PageVoirPromos, Action DemandeValidation)
        {
            Grid.SetColumn(this, 0);

            // Créer un pinceau avec la couleur hexadécimale
            var brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));
            this.Background = brush;
            this.Width = 100;
            this.Children.Add(new Button_icon("CabinetFiles", 60, 60, PageCreateTp));
            this.Children.Add(new Button_icon("CabinetFilesVariant", 60, 60, PageListTP));
            this.Children.Add(new Button_icon("People", 60, 60, PageVoirEleves));
            this.Children.Add(new Button_icon("PeopleMultiple", 60, 60, PageVoirPromos));
            this.Children.Add(new Button_icon("Check", 60, 60, DemandeValidation));
        }

    }       

}
