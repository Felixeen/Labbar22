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

namespace Uppgift15v2
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

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            int amount = 0;

            string seekLetter = seekBox.Text;
            string lcaseSeekLetter = seekLetter.ToLower();
            char letter = char.Parse(lcaseSeekLetter);

            string text = txtBox.Text;
            string lcaseText = text.ToLower();
            char[] charArray = lcaseText.ToCharArray();




            // foreach (char letter in charArray) and if found letter, add 1 to amount

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == letter)
                {
                    amount++;
                }
            }

            txtBlock.Text = Convert.ToString("Hittade bokstaven " + Char.ToUpper(letter) + " " + amount + " gånger!!");
        }
    }
}
