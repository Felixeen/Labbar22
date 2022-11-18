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

namespace Uppgift13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string[] fruits = { "äpple", "päron", "banan", "ananas", "melon", "jäger" };
        }
        
        //static void Main (string[] args)
       // {

       //     string[] fruits = { "äpple", "päron", "banan", "ananas", "melon" };

       //     foreach (string fruit in fruits)
       //     {
       //         MessageBox.Show(fruit);
      //      }
      //  }
        
        static string[] test(string[] fruits)
           
        {
                return new string[] { fruits[fruits.Length / 2 - 1], fruits[fruits.Length / 2] };
        }

        private void firstBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] fruits = { "äpple", "päron", "banan", "ananas", "melon" };
            MessageBox.Show(fruits[0]);
        }

        private void lastBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] fruits = { "äpple", "päron", "banan", "ananas", "melon" };
            
            MessageBox.Show(fruits[fruits.Length - 1]);
        }

        private void middleBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] fruits = { "äpple", "päron", "banan", "ananas", "melon" };


            //for (int i = 0; i < fruits.Length; ++i)
            {
                if (fruits.Length % 2 == 0)
                {
                    MessageBox.Show(fruits[fruits.Length / 2 - 1] + " & " + fruits[fruits.Length / 2]);
                }

                else
                {
                    MessageBox.Show(fruits[fruits.Length / 2]);
                }

            }
                
            
            //MessageBox.Show(fruits[fruits.Length / 2 - 1], fruits[fruits.Length / 2]);
        }
    }
}
