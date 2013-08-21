using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading;

namespace Simon
{

    
    public partial class Gioco : PhoneApplicationPage
    {

        double opac = 0.3;
        public Gioco()
        {
            InitializeComponent();

            SuonoBottone1.Visibility = System.Windows.Visibility.Collapsed;
            SuonoBottone2.Visibility = System.Windows.Visibility.Collapsed;
            SuonoBottone3.Visibility = System.Windows.Visibility.Collapsed;
            SuonoBottone4.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Bottone1(object sender, RoutedEventArgs e)
        {
            SuonoBottone1.Play();
        }

        private void Bottone2(object sender, RoutedEventArgs e)
        {
            Button2.Opacity = opac;
            SuonoBottone2.Play();
            Thread.Sleep(200);
           // Button2.Opacity = 1;
        }

        private void Bottone3(object sender, RoutedEventArgs e)
        {
            Button3.Opacity = opac;
            SuonoBottone3.Play();
            Thread.Sleep(200);
           // Button3.Opacity = 1;
        }

        private void Bottone4(object sender, RoutedEventArgs e)
        {
            Button4.Opacity = opac;
            SuonoBottone4.Play();
            Thread.Sleep(200);
            Button4.Opacity = 1;
        }




    }
}