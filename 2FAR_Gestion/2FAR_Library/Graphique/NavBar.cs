using System;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;



namespace _2FAR_Library.Graphique
{
    public class NavBar : StackPanel
    {
        public NavBar(Action PageCreateTp, Action PageListTP, Action PageVoirEleves, Action PageVoirPromos, Action DemandeValidation)
        {
            Grid.SetColumn(this, 0);

            // Créer un pinceau avec la couleur hexadécimale
            var brush = new SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));
            Background = brush;
            Width = 100;
            Children.Add(new Button_icon("CabinetFiles", 60, 60, PageCreateTp));
            Children.Add(new Button_icon("CabinetFilesVariant", 60, 60, PageListTP));
            Children.Add(new Button_icon("People", 60, 60, PageVoirEleves));
            Children.Add(new Button_icon("PeopleMultiple", 60, 60, PageVoirPromos));
            Children.Add(new Button_icon("Check", 60, 60, DemandeValidation));
        }

    }

}
