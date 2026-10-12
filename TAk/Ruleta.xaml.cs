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
using System.Windows.Shapes;

namespace TAk
{
    /// <summary>
    /// Logika interakcji dla klasy Ruleta.xaml
    /// </summary>
    public partial class Ruleta : Window
    {
        public Ruleta()
        {
            InitializeComponent();
            punktyy.Text = "Punkty:" + MainWindow.Dane.punkty.ToString();
        }
        private void Powrot(object sender, RoutedEventArgs e)
        {
            MainWindow Powrot = new MainWindow();
            Powrot.Show();

            this.Close();
        }
        int a = 0;
        private void WybierzLiczbe(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            a = int.Parse(btn.Content.ToString());
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            int wynik = new Random().Next(0, 13);
            Wynik.Text = "Obecna Liczba:\n" + wynik.ToString();
            if(a == wynik)
            {
                MessageBox.Show("Wygrałeś");
                MainWindow.Dane.punkty += Jedynki + (dychy * 10) + (setki * 100);
            }
            else
            {
                MessageBox.Show("Przegrałeś");
                MainWindow.Dane.punkty -= Jedynki + (dychy * 10) + (setki * 100);
            }
            punktyy.Text = "Punkty:" + MainWindow.Dane.punkty.ToString();
        }
        int Jedynki = 0;
        int dychy = 0;
        int setki = 0;
        private void Plus1(object sender, RoutedEventArgs e)
        {
            Jedynki++;
        }

        private void Plus10(object sender, RoutedEventArgs e)
        {
            dychy++;
        }

        private void Plus100(object sender, RoutedEventArgs e)
        {
            setki++;
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            dychy = 0;
            Jedynki = 0;
            setki = 0;
        }
    }
}
