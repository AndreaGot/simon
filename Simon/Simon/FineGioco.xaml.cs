﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace Simon
{
    public partial class FineGioco : PhoneApplicationPage
    {
        public FineGioco()
        {
            InitializeComponent();
            Risultato.Text = "Livello " + PhoneApplicationService.Current.State["ris"].ToString();
        }

        private void ShareNewsArticle(string message)
        {
            ShareStatusTask sst = new ShareStatusTask();
            sst.Status = message;
            sst.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShareNewsArticle("Ho giocato a #SimoneDice e ho raggiunto il Livello " + PhoneApplicationService.Current.State["ris"].ToString() + "!");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Gioco.xaml", UriKind.Relative));

        }
    }
}