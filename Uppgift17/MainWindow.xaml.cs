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

namespace Uppgift17
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

        private void NumberOfVowels()
        {
            string mening = textBox.Text;
            int numberOfVowels = 0;
            for (int i = 0; i < mening.Length; i++)
            {
                if (mening[i] == 'a' || mening[i] == 'e' || mening[i] == 'i' || mening[i] == 'o' || mening[i] == 'u')
                {
                    numberOfVowels++;
                }
                else if (mening[i] == 'A' || mening[i] == 'E' || mening[i] == 'I' || mening[i] == 'O' || mening[i] == 'U')
                {
                    numberOfVowels++;
                }
            }
            vowelsBlock.Text = "Antal vokaler: " + numberOfVowels.ToString();

        }


        private void Jibberish()
        {
            string mening = textBox.Text;
            for (int i = 0; i < mening.Length; i++)
            {
                if (mening[i] == 'a' || mening[i] == 'e' || mening[i] == 'i' || mening[i] == 'o' || mening[i] == 'u')
                {
                    mening = mening.Replace(mening[i], 'ö');
                }
                
                else if (mening[i] == 'A' || mening[i] == 'E' || mening[i] == 'I' || mening[i] == 'O' || mening[i] == 'U')
                {
                    mening = mening.Replace(mening[i], 'Ö');
                }
            }
            resultBlock.Text = mening.ToString();

        }

        private bool IsVowel()
        {
            string mening = textBox.Text;
            for (int i = 0; i < mening.Length; i++)
            {
                if (mening[i] == 'a' || mening[i] == 'e' || mening[i] == 'i' || mening[i] == 'o' || mening[i] == 'u')
                {
                    return true;
                }
                else if (mening[i] == 'A' || mening[i] == 'E' || mening[i] == 'I' || mening[i] == 'O' || mening[i] == 'U')
                {
                    return true;
                }
            }
            return false;
        }
        




        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            NumberOfVowels();
            Jibberish();
            IsVowel();
        }
        
        
        
    }

    

    
}
