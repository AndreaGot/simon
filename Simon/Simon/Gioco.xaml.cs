using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
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

         void DiventaOpaco1(object sender, EventArgs e)
        {
            DispatcherTimer dt = (DispatcherTimer)sender;
            Button1.Opacity = 1;
        }

         void DiventaOpaco2(object sender, EventArgs e)
         {
             DispatcherTimer dt = (DispatcherTimer)sender;
             Button2.Opacity = 1;
         }

         void DiventaOpaco3(object sender, EventArgs e)
         {
             DispatcherTimer dt = (DispatcherTimer)sender;
             Button3.Opacity = 1;
         }

         void DiventaOpaco4(object sender, EventArgs e)
         {
             DispatcherTimer dt = (DispatcherTimer)sender;
             Button4.Opacity = 1;
         }

        private void Bottone1(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += new EventHandler(DiventaOpaco1);

            Button1.Opacity = opac;
            SuonoBottone1.Play();
            timer.Start();
        }

        private void Bottone2(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += new EventHandler(DiventaOpaco2);
            
            Button2.Opacity = opac;
            SuonoBottone2.Play();
            timer.Start();
        }

        private void Bottone3(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += new EventHandler(DiventaOpaco3);

            Button3.Opacity = opac;
            SuonoBottone3.Play();
            timer.Start();
        }

        private void Bottone4(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += new EventHandler(DiventaOpaco4);

            Button4.Opacity = opac;
            SuonoBottone4.Play();
            timer.Start();
        }




    }
}