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

namespace OhjelmaLogiikkaWpf
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

        private void btnViikonpaiva_Click(object sender, RoutedEventArgs e)
        {
            DateTime tänään = DateTime.Today;
            if (tänään.DayOfWeek == DayOfWeek.Monday)
            {
                MessageBox.Show("Tänään on maanantai");
            }
            else if (tänään.DayOfWeek == DayOfWeek.Tuesday)
            {
                MessageBox.Show("Tänään on tiistai");
            }
            else if (tänään.DayOfWeek == DayOfWeek.Wednesday)
            {
                MessageBox.Show("Tänään on keskiviikko");
            }
            else if (tänään.DayOfWeek == DayOfWeek.Thursday)
            {
                MessageBox.Show("Tänään on torstai");
            }
            else if (tänään.DayOfWeek == DayOfWeek.Friday)
            {
                MessageBox.Show("Tänään on perjantai");
            }
            else if (tänään.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("Tänään on lauantai");
            }
            else if (tänään.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Tänään on sunnuntai");
            }
        }

        private void btnVertailu_Click(object sender, RoutedEventArgs e)
        {
            int i = 123;
            string s = "123";

            // vaihtoehto 1, muunnetaan molemmat int-tyyppisiksi
            if (i == int.Parse(s))
            {
                MessageBox.Show("Ovat samoja!");
            }
            // vaihtoehto 2, muunnetaan molemmat merkkijonoiksi
            if (i.ToString() == s)
            {
                MessageBox.Show("Ovat samoja!");
            }
        }

        private void btnVertaile_Click(object sender, RoutedEventArgs e)
        {
            int i = 123;
            string s = "123";
            VertaileLukuJaMerkkijono(i, s);

            i = 234;
            s = "234";
            VertaileLukuJaMerkkijono(i, s);

            i = 345;
            s = "345";
            VertaileLukuJaMerkkijono(i, s);

            i = 456;
            s = "666";
            VertaileLukuJaMerkkijono(i, s);
        }
        private static void VertaileLukuJaMerkkijono(int i, string s)
        {
            if (i == int.Parse(s))
            {
                MessageBox.Show("Ovat samoja!");
            }
            else
            {
                MessageBox.Show("Eivät ole samoja!");
            }
        }

        private void btnLoop_Click(object sender, RoutedEventArgs e)
        {
            string s = "A";
            // for-silmukka (engl. for loop)
            for (int i = 0; i < 1000; i++)
            {
                s = s + "A";
            }
            MessageBox.Show(s);

            // do-while -silmukka
            do
            {
                MessageBox.Show("Hiphei!");
            }
            while (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday);
        }

        private void btnLuku_Click(object sender, RoutedEventArgs e)
        {
            sbyte b = sbyte.Parse(txtLuku.Text);
            b = (sbyte)(b + 1);
            MessageBox.Show("B:n arvo = " + b);
        }
    }
}
