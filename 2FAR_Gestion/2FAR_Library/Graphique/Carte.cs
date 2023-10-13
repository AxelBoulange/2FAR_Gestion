﻿using _2FAR_Library.Graphique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _2FAR_Library
{
    public class Carte : Grid
    {
        public Carte(string title, string content, List<Action> actionButtons)
        {
            var brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));
            Border border = new Border();
            Grid container = new Grid();
            StackPanel stackPanel = new StackPanel();
            this.Children.Add(border);
            border.BorderThickness = new Thickness(1);
            border.BorderBrush = brush;
            border.Child = container;
            border.Height = 130;
            border.Width = 600;
            container.Children.Add(new title_Carte(title));
            container.Children.Add(new content_Carte(content));
            container.Children.Add(stackPanel);
            stackPanel.HorizontalAlignment = HorizontalAlignment.Right;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;
            stackPanel.Children.Add(new Btn("consulter", actionButtons[0]));
            stackPanel.Children.Add(new Btn("modifier", actionButtons[1]));
            stackPanel.Children.Add(new Btn("supprimer", actionButtons[2]));
            this.Margin = new Thickness(0, 0, 0, 20);
        }
        public Carte(string title, string content, Action actionButton)
        {
            var brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));
            Border border = new Border();
            Grid container = new Grid();
            StackPanel stackPanel = new StackPanel();
            this.Children.Add(border);
            border.BorderThickness = new Thickness(1);
            border.BorderBrush = brush;
            border.Child = container;
            border.Height = 130;
            border.Width = 600;
            container.Children.Add(new title_Carte(title));
            container.Children.Add(new content_Carte(content));
            container.Children.Add(stackPanel);
            stackPanel.HorizontalAlignment = HorizontalAlignment.Right;
            stackPanel.VerticalAlignment = VerticalAlignment.Center;
            stackPanel.Children.Add(new Btn("consulter", actionButton));
            this.Margin = new Thickness(0, 0, 0, 20);
        }
    }
    public class title_Carte : Label
    {
        public title_Carte(string content)
        {
            var brush = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("white"));
            HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            this.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            this.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;
            Height = 100;
            Width = 80;
            this.Margin = new Thickness(10);
            this.Content = content;
            this.Foreground = brush;
            this.Background = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#5e17eb"));

        }
    }
    public class content_Carte : Label
    {
        public content_Carte(string content)
        {
            HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            VerticalAlignment = System.Windows.VerticalAlignment.Center;
            VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
            this.Content = content;
            Height = 100;

        }
    }
}
