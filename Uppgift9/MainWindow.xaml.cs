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

namespace Uppgift9
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

        private void konBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(galBox.Text) || string.IsNullOrEmpty(sikBox.Text) || string.IsNullOrEmpty(knutBox.Text))
            {
                MessageBox.Show("Du måste ange ett värde");
                return;
            }
            
            int gal = int.Parse(galBox.Text);
            int sik = int.Parse(sikBox.Text);
            int knut = int.Parse(knutBox.Text);


            double galSek = 62.02;
            
            double gal1 = gal * galSek;
            double sik1 = sik / 17 * galSek;
            double knut1 = knut / 493 * galSek;

            double sum = gal1 + sik1 + knut1;







            summa.Content = sum.ToString ("#") + " SEK";



            //summa.Content = sum.ToString(sum + " SEK");
        }
    }
}
