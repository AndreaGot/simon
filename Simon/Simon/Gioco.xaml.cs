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
using System.Threading.Tasks;
namespace Simon
{

    
    public partial class Gioco : PhoneApplicationPage
    {
        int[] tasti = new int[100];
        int sequenza = 0;
        int livello = 1;
        double opac = 0.3;



        public Gioco()
        {
            Random tst = new Random();
            InitializeComponent();

            SuonoBottone1.Visibility = System.Windows.Visibility.Collapsed;
            SuonoBottone2.Visibility = System.Windows.Visibility.Collapsed;
            SuonoBottone3.Visibility = System.Windows.Visibility.Collapsed;
            SuonoBottone4.Visibility = System.Windows.Visibility.Collapsed;

            for(int i=0;i<100;i++)
            {
                tasti[i] = tst.Next(1, 4);
            }

            IniziaGioco();
        }

         void DiventaOpaco1(object sender, EventArgs e)
        {
            Button1.Opacity = 1;
        }
         void DiventaOpaco2(object sender, EventArgs e)
         {
             Button2.Opacity = 1;
         }
         void DiventaOpaco3(object sender, EventArgs e)
         {
             Button3.Opacity = 1;
         }
         void DiventaOpaco4(object sender, EventArgs e)
         {
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


            sequenza++;
            if (ControllaGiusto(1))
            {
                if (sequenza == livello)
                {
                    livello++;
                    sequenza = 0;
                    Titolo.Text = "Livello " + livello;
                    IniziaGioco();
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/FineGioco.xaml", UriKind.Relative));
            }

        }

        private void Bottone2(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += new EventHandler(DiventaOpaco2);
            
            Button2.Opacity = opac;
            SuonoBottone2.Play();
            timer.Start();


            sequenza++;
            if (ControllaGiusto(2))
            {
                if (sequenza == livello)
                {
                    livello++;
                    sequenza = 0;
                    Titolo.Text = "Livello " + livello;
                    IniziaGioco();
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/FineGioco.xaml", UriKind.Relative));
            }

        }

        private void Bottone3(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += new EventHandler(DiventaOpaco3);

            Button3.Opacity = opac;
            Titolo.Text = "Livello " + livello;
            SuonoBottone3.Play();
            timer.Start();


            sequenza++;
            if (ControllaGiusto(3))
            {
                if (sequenza == livello)
                {
                    livello++;
                    sequenza = 0;
                    Titolo.Text = "Livello " + livello;
                    IniziaGioco();
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/FineGioco.xaml", UriKind.Relative));
            }

        }

        private void Bottone4(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
            timer.Tick += new EventHandler(DiventaOpaco4);

            Button4.Opacity = opac;
            SuonoBottone4.Play();
            timer.Start();

            sequenza++;
            if (ControllaGiusto(4))
            {
                if (sequenza == livello)
                {
                    livello++;
                    sequenza = 0;
                    Titolo.Text = "Livello " + livello;
                    IniziaGioco();
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/FineGioco.xaml", UriKind.Relative));
            }
            
        }


        async void IniziaGioco()
        {
            if (livello == 0)
                await Task.Delay(2000);
            else
                await Task.Delay(1000);

            for (int i = 0; i < livello; i++)
            {
                switch (tasti[i])
                {
                    case 1:
                        DispatcherTimer timer = new DispatcherTimer();
                        timer.Interval = new TimeSpan(0, 0, 0, 0, 300);
                        timer.Tick += new EventHandler(DiventaOpaco1);
                        Button1.Opacity = opac;
                        SuonoBottone1.Play();
                        timer.Start();
                        //timer5.Start();
                        break;
                    case 2:
                        DispatcherTimer timer2 = new DispatcherTimer();
                        timer2.Interval = new TimeSpan(0, 0, 0, 0, 300);
                        timer2.Tick += new EventHandler(DiventaOpaco2);
                        Button2.Opacity = opac;
                        SuonoBottone2.Play();
                        timer2.Start();
                        //timer5.Start();
                        break;
                    case 3:
                        DispatcherTimer timer3 = new DispatcherTimer();
                        timer3.Interval = new TimeSpan(0, 0, 0, 0, 300);
                        timer3.Tick += new EventHandler(DiventaOpaco3);
                        Button3.Opacity = opac;
                        SuonoBottone3.Play();
                        timer3.Start();
                        //timer5.Start();
                        break;
                    case 4:
                        DispatcherTimer timer4 = new DispatcherTimer();
                        timer4.Interval = new TimeSpan(0, 0, 0, 0, 300);
                        timer4.Tick += new EventHandler(DiventaOpaco4);
                        Button4.Opacity = opac;
                        SuonoBottone4.Play();
                        timer4.Start();
                       
                        break;
                }

                if (livello < 4)
                {
                    await Task.Delay(1000);
                }
                else if (livello > 3 && livello < 9)
                {
                    await Task.Delay(800);
                }
                else if (livello > 8 && livello < 16)
                {
                    await Task.Delay(500);
                }
                else
                {
                    await Task.Delay(300);
                }

                

            }

        }
        bool ControllaGiusto(int x)
        {
            if (tasti[sequenza - 1] != x)
                return false;
            else
                return true;
        }
 
    }
}