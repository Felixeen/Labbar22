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

namespace Uppgift6
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
        //Addition
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double txt1 = Convert.ToDouble(txtBox.Text);
            double txt2 = Convert.ToDouble(txtBox2.Text);

            //Limiterar till max 2 decimaler
            double sum = txt1 + txt2;

            //Koden nedan fyller samma funktion för avrundning
            //sumBox.Text = sum.ToString("#.##");

            //Avrundning av kod till 2 decimaler
            sumBox.Text = $"{Math.Round(sum, 2)}";

            resBlock.Text = string.Format("Summa");






        }
        //Subtraktion
        private void subBtn_Click(object sender, RoutedEventArgs e)
        {
            double txt1 = Convert.ToDouble(txtBox.Text);
            double txt2 = Convert.ToDouble(txtBox2.Text);

            double sum = txt1 - txt2;

            sumBox.Text = $"{Math.Round(sum, 2)}";


            resBlock.Text = string.Format("Differens");

        }
        //Multiplikation
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double txt1 = Convert.ToDouble(txtBox.Text);
            double txt2 = Convert.ToDouble(txtBox2.Text);

            double sum = txt1 * txt2;

            sumBox.Text = $"{Math.Round(sum, 2)}";


            resBlock.Text = string.Format("Kvot");
        }
        //Divition
        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            double txt1 = Convert.ToDouble(txtBox.Text);
            double txt2 = Convert.ToDouble(txtBox2.Text);

            double sum = txt1 / txt2;

            sumBox.Text = $"{Math.Round(sum, 2)}";



            resBlock.Text = string.Format("Produkt");
        }
        //Metod för att rensa input i textrutorna
        private void Rensa_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
            txtBox2.Clear();
            sumBox.Clear();

            //Återställer till ursprungsfras i programt aka NOllställning
            resBlock.Text = string.Format("Resultat");
        }
    }

}
