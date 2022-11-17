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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            valueBlock.Text = (int)progressBar.Value + "%";
        }

        private void moreBtn_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value += 5;
            valueBlock.Text = (int)(progressBar.Value) + "%";
            
        }

        private void lessBtn_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value -= 5;
            valueBlock.Text = (int)(progressBar.Value) + "%";
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            int tries = int.Parse(triesBox.Text);

            Random odds = new Random();

            int oddsResultat = 0;

            for (int i = 0; i < tries; i++)
            {
                int nummerGen = odds.Next(100);

                if (nummerGen >= progressBar.Value)
                {
                    oddsResultat++;
                }
            }
            rightBlock.Text = "Antal åt rätt håll: " + oddsResultat.ToString();
            wrongBlock.Text = "Antal åt fel håll: " + (tries - oddsResultat).ToString();
        }
    }
}
