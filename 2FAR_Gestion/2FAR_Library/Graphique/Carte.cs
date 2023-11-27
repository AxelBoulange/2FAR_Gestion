using _2FAR_Library.Graphique;
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
        public Carte(string title, string content, Dictionary<string, Action> actionButtons, int TitleSize, int DescSize)
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
            Grid.SetColumn(cardContent, 1);
            grid.Children.Add(cardContent);


            StackPanel stackPanel = new StackPanel();
            stackPanel.HorizontalAlignment = HorizontalAlignment.Center;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;
            stackPanel.Margin = new Thickness(5, 5, 5, 5);
            
            foreach (var action in actionButtons)
            {
                Btn boutton = new Btn(action.Key, action.Value);
                boutton.Margin = new Thickness(0, 5, 0, 5);
                stackPanel.Children.Add(boutton);
            }

            Grid.SetColumn(stackPanel, 2);
            grid.Children.Add(stackPanel);


        }
    }
}
