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
            myBrowser.Navigate(new Uri("http://www.google.com"));
        }

        private void btnTervehdys_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Heissan," + txtName.Text + "!");
            txtHei.Text = "Hyvä!!!!";
        }

        private void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hei, maailma!");
            MessageBox.Show("Hello World!");
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
            VertaileLukuJaMerkkijono(i, s); //tehty if - else -lausekkeesta rutiini VertaileLukuJaMerkkijono
            //Edit > Refactor > Extract Method

            i = 234;
            s = "234";
            VertaileLukuJaMerkkijono(i, s);
            //Refactoroitu rutiiniksi:
            //if (i == int.Parse(s))
            //{
            //    MessageBox.Show("Ovat samoja!");
            //}
            //else
            //{
            //    MessageBox.Show("Eivät ole samoja!");
            //}

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

        //2. Ref -esimerkki
        private void btnVertaileLukuJaMerkkijonoRef_Click(object sender, RoutedEventArgs e)
        {
            //käytetään metodia (Edit > Refactor > Extract Method) = 
            //luodaan valitusta lohkosta valmis rutiini > annetaan rutiinille nimi:
            //VertaileLukuJaMerkkijono(i, s);

                //int = value (arvo)
                //määritetään int i referenssinä > parametristä tulee viittaustyyppi (reference) = (ref i, s)
                //VertaileLukuJaMerkkijono rutiinille kerrotaan, että luku on alkuperäisessä merkkijonossa
                int i = 123;
                string s = "123";
                VertaileLukuJaMerkkijonoRef(ref i, s);

                i = 234;
                s = "234";
                VertaileLukuJaMerkkijonoRef(ref i, s);

                i = 345;
                s = "345";
                VertaileLukuJaMerkkijonoRef(ref i, s);

                i = 456;
                s = "666";
                VertaileLukuJaMerkkijonoRef(ref i, s);
        }

            //uusi rutiinimuodostuu>
            private static void VertaileLukuJaMerkkijonoRef(ref int i, string s)
            {
                if (i == int.Parse(s))
                {
                    MessageBox.Show("Ovat samoja!");
                }
                else
                {
                    MessageBox.Show("Eivät ole samoja!");
                }
                //lisää yhden luvun
                i = i + 1;
            }
        

        private void btnLoop_Click(object sender, RoutedEventArgs e)
        {
            string s = "A";

            //kirjoita for ja paina 2 kertaa tab:
            // for-silmukka (engl. for loop)
            for (int i = 0; i < 1000; i++)
            {
                s = s + "A";
            }
            MessageBox.Show(s);

            //kirjoita do ja paina 2 kertaa tab:
            // do-while -silmukka
            do
            {
                MessageBox.Show("Hiphei!");
                //toteutuu niin kauan kuin ehto toteutuu
                //jos ei ole ehtoa, tulee loputon silmukka
            }
            while (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday);
        }


        private void btnLuku_Click(object sender, RoutedEventArgs e)
        {
            sbyte b = sbyte.Parse(txtLuku.Text);
            b = (sbyte)(b + 1);
            MessageBox.Show("B:n arvo = " + b);
        }

        private void btnDoWhile_Click(object sender, RoutedEventArgs e)
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
            while (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday);
        }

        private void btnFor_Click(object sender, RoutedEventArgs e)
        {
            string s = "B";

            for (int i = 10; i < 500; i++)

            {
                s = s + "B";
            }
            MessageBox.Show(s);
            //muodostuu 491 B:tä
        }


        //Navigointi:
        private void btnDefaultSite_Click(object sender, RoutedEventArgs e)
        {
            myBrowser.Navigate(new Uri("http://www.google.com"));
        }

        private void btnNumerotyyppi_Click(object sender, RoutedEventArgs e)

        //unsigned integer byte = ei voi olla negatiivinen luku
        {
            byte b = byte.Parse(txtByte.Text);//Parse = käännetään txtboxin luku merkkijonoksi
            b = (byte)(b + 1);
            MessageBox.Show("B:n arvo = " + b);
        }

        private void btnSignedByte_Click(object sender, RoutedEventArgs e)
        //signed integer sbyte = luvut -128 to 127
        {
            sbyte b = sbyte.Parse(txtSbyte.Text);
            b = (sbyte)(b + 1);
            MessageBox.Show("B:n arvo = " + b);
        }


    }
}
