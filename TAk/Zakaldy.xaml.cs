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
        }

        private void Powrot(object sender, RoutedEventArgs e)
        {
            MainWindow Powrot = new MainWindow();
            Powrot.Show();

            this.Close();
        }
    }
}
