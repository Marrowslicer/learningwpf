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

namespace P006_LearningBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSmallButtonClick(object sender, RoutedEventArgs e)
        {
            TargetObject.FontSize = 12;
        }

        private void OnMiddleButtonClick(object sender, RoutedEventArgs e)
        {
            TargetObject.FontSize = 24;
        }

        private void OnLargeButtonClick(object sender, RoutedEventArgs e)
        {
            TargetObject.FontSize = 48;
        }
    }
}
