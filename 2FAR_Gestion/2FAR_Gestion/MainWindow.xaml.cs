﻿using System;
using System.Windows;
using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _2FAR_Library;

namespace _2FAR_Gestion
{
    public partial class MainWindow : MetroWindow
    {
        public  AdoAll all;

        public MainWindow()
        {
            AdoAll allStart = new AdoAll();
            all = allStart;
            InitializeComponent();
            this.Content = new PageAccueil(all);
        }
        //private void MainWindow_Closing()
        //{

        //}
    }
}