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
    /// Logika interakcji dla klasy BlackJack.xaml
    /// </summary>
    public partial class BlackJack : Window
    {
        public BlackJack()
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

        private void Start(object sender, RoutedEventArgs e)
        {
            int PierwszaKarta = new Random().Next(1, 7);
            int DrugaKarta = new Random().Next(1, 7);
            int TrzeciaKarta = new Random().Next(1, 7);

            Jeden.Text = PierwszaKarta.ToString();
            Dwa.Text = DrugaKarta.ToString();
            Trzy.Text = TrzeciaKarta.ToString();

            if (PierwszaKarta == DrugaKarta && DrugaKarta == TrzeciaKarta)
            {
                MessageBox.Show("Wygrałeś");
                MainWindow.Dane.punkty += 100;
            }
            else
            {
                MessageBox.Show("Przegrałeś");
                MainWindow.Dane.punkty -= 10;
            }
            punktyy.Text = "Punkty:" + MainWindow.Dane.punkty.ToString();
        }
    }
}
