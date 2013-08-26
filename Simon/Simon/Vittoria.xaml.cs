using System;
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
    public partial class Vittoria : PhoneApplicationPage
    {
        public Vittoria()
        {
            InitializeComponent();
        }

        private void ShareNewsArticle(string message)
        {
            ShareStatusTask sst = new ShareStatusTask();
            sst.Status = message;
            sst.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShareNewsArticle("Ho giocato a #SimoneDice e ho vinto, raggiungendo il Livello " + PhoneApplicationService.Current.State["ris"].ToString() + "! Riuscirai a battermi?");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Gioco.xaml", UriKind.Relative));

        }
    }
}