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
    /// Logika interakcji dla klasy Zakaldy.xaml
    /// </summary>
    public partial class Zakaldy : Window
    {
        public Zakaldy()
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
        int bet = 0;
        private void Start(object sender, RoutedEventArgs e)
        {
            int wynik = new Random().Next(1, 4);
            Wynik.Text = "Obecna Liczba:\n" + wynik.ToString();
            bet = int.Parse(WpiszKwote.Text);
            if (a == wynik)
            {
                MessageBox.Show("Wygrałeś");
                MainWindow.Dane.punkty += bet;
            }
            else
            {
                MessageBox.Show("Przegrałeś");
                MainWindow.Dane.punkty -= bet;
            }
            punktyy.Text = "Punkty:" + MainWindow.Dane.punkty.ToString();
        }
    }
}
