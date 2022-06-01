using System;
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
using System.Windows.Threading;

namespace Firma
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        double szerokoscMenu;
        bool ukryte;

        public MainWindow()
        {
            InitializeComponent();

            //Ustawienie obecnej daty w StatusBar
            WyswietlCzas.Text = DateTime.Now.ToString("dd MMMM yyyy");

            //Ustawienie timera oraz prędkości rozsuwania się menu
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            timer.Tick += Timer_Tick;

            szerokoscMenu = menuBoczne.Width;
        }

        //Metoda służąca do rozsuwania menu bocznego. Z każdym tickiem rozsuwa się o jeden
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ukryte)
            {
                menuBoczne.Width += 1;
                if (menuBoczne.Width >= szerokoscMenu)
                {
                    timer.Stop();
                    ukryte = false;
                }
            }
            else
            {
                menuBoczne.Width -= 1;
                if (menuBoczne.Width <= 35)
                {
                    timer.Stop();
                    ukryte = true;
                }
            }
        }
        
        //Uruchomienie rozsuwania po kliknięciu w przycisk menu
        private void Klik(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
