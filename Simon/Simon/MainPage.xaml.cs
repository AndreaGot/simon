﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Simon
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Informazioni.xaml", UriKind.Relative));
        }

        private void Gioca(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Gioco.xaml", UriKind.Relative));
        }

        private void Istruzioni(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Istruzioni.xaml", UriKind.Relative));

        }

    }
}