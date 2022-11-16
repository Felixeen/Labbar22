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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;
        int min100 = 100;
        
       
        public MainWindow()
        {
            InitializeComponent();
            
        }
        


        
        private void slumpBtn_Click(object sender, RoutedEventArgs e)
        {
            guessBtn.IsEnabled = true;
            slumpBtn.IsEnabled = false;
            number = randomNumber.Next(0, 1000);

            svarBlock.Text = Convert.ToString("Jag har valt ett tal mellan 0 och 1000. Gissa vilket tal jag har valt.");
        }

        private void guessBtn_Click(object sender, RoutedEventArgs e)
        {

            
            int i = Convert.ToInt32(guessBox.Text);

            guesses += 1;
            svarBlock.Text = "Du har gissat " + guesses + " gånger";

            if (i == number)
            {
                guessBtn.IsEnabled = false;
                slumpBtn.IsEnabled = true;
                MessageBox.Show("Helt rätt! Tryck på Slumpa tal för att försöka igen?");
               
                guesses = 0;
                svarBlock.Text = "Du har gissat " + guesses + " gånger";
            }
            else if (i < number)
            {
                MessageBox.Show("Gissa högre");
            }
            else if (i > number)
            {
                MessageBox.Show("Gissa lägre");
            }
            else if (i > number + min100)
            {
                MessageBox.Show("Nu är du långt ifrån... gissa mycket lägre");
            }
            else if (i < number - min100)
            {
                MessageBox.Show("Nu är du långt ifrån... gissa mycket högre");
            }
        }
    }
}
