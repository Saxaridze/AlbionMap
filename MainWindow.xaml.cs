﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace AlbionMap
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Meneger.MainFraim = MainFrame;
            MainFrame.Navigate(new TableMap());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

        }

    }
}
