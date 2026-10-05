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
        public MainWindow()
        {
            InitializeComponent();
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
    }
}