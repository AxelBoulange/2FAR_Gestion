﻿using _2FAR_Library.Graphique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Btn = _2FAR_Library.Graphique.Btn;

namespace _2FAR_Library
{
    public class Carte : Border
    {
        public Carte(string title, string content, Dictionary<string, Action<int>> actionButtons, int TitleSize, int DescSize, int Id)
        {
            BorderBrush = new System.Windows.Media.SolidColorBrush(
                (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));
            BorderThickness = new Thickness(1);
            this.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.Margin = new Thickness(20, 20, 20, 20);

            Grid grid = new Grid();
            for (int i = 0; i < 3; i++) //faire 3 column
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            grid.Margin = new Thickness(20, 20, 20, 20);
            Child = grid;

            Label cardTitle = new Label();
            cardTitle.HorizontalAlignment = HorizontalAlignment.Stretch;
            cardTitle.VerticalAlignment = VerticalAlignment.Stretch;
            cardTitle.Content = title;
            cardTitle.Foreground = Brushes.White;
            cardTitle.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5e17eb"));
            cardTitle.FontSize = TitleSize;
            cardTitle.FontWeight = FontWeights.Bold;
            cardTitle.HorizontalContentAlignment = HorizontalAlignment.Center;
            cardTitle.VerticalContentAlignment = VerticalAlignment.Center;
            Grid.SetColumn(cardTitle, 0);
            grid.Children.Add(cardTitle);


            TextBlock cardContent = new TextBlock();
            cardContent.TextWrapping = TextWrapping.Wrap;
            cardContent.HorizontalAlignment = HorizontalAlignment.Center;
            cardContent.VerticalAlignment = VerticalAlignment.Center;
            cardContent.Text = content;
            cardContent.Foreground = Brushes.Black;
            cardContent.FontSize = DescSize;
            cardContent.FontWeight = FontWeights.Bold;
            cardContent.Padding = new Thickness(15);
            Grid.SetColumn(cardContent, 1);
            grid.Children.Add(cardContent);


            
            StackPanel stackPanel = new StackPanel();
            stackPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
            stackPanel.VerticalAlignment = VerticalAlignment.Stretch;

            
            foreach (var action in actionButtons)
            {
                Btn button = new Btn(action.Key, action.Value, Id);
                button.Margin = new Thickness(0, 5, 0, 5);
                button.HorizontalAlignment = HorizontalAlignment.Stretch;
                button.VerticalAlignment = VerticalAlignment.Stretch;

                button.Height = 40;

                if (action.Key == "supprimer")
                {
                    button.Background = Brushes.Red;
                }
                stackPanel.Children.Add(button);

            }

            Grid.SetColumn(stackPanel, 2);
            grid.Children.Add(stackPanel);


        }
    }
}
