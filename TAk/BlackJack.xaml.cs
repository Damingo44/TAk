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
        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            MainWindow Powrot = new MainWindow();
            Powrot.Show();

            this.Close();
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            int PierwszaKarta = new Random().Next(1, 11);
            int DrugaKarta = new Random().Next(1, 11);
            int TrzeciaKarta = new Random().Next(1, 11);
            int wynik = PierwszaKarta + DrugaKarta + TrzeciaKarta;

        }
    }
}
