using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TAk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static class Dane
        {
            public static int punkty = 1000;
        }
        public MainWindow()
        {
            InitializeComponent();
            punktyy.Text = "Punkty:" + Dane.punkty.ToString();

        }

        private void Ruletka(object sender, RoutedEventArgs e)
        {
            Ruleta Okno = new Ruleta();
            Okno.Show();

            this.Close();
        }

        private void Zaklady(object sender, RoutedEventArgs e)
        {
            Zakaldy Okno = new Zakaldy();
            Okno.Show();

            this.Close();
        }

        private void BlackJack(object sender, RoutedEventArgs e)
        {
            BlackJack Okno = new BlackJack();
            Okno.Show();

            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            Dane.punkty = 1000;
        }
    }
}