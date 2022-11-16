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

namespace Uppgift10
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

        private void ctrlBtn_Click(object sender, RoutedEventArgs e)
        {
            slumpBtn.IsEnabled = false;
            
            string name = nameBox.Text;
            int age = int.Parse(ageBox.Text);
            

            if (age >= 15)
            {
                if (medOk.IsChecked == true)
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år gammal och behöder ingen vuxen för" +
                        " du får se alla filmer själv om du vill.");
                }
                else if (utanOk.IsChecked == true)
                
               
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år och du får se alla filmer.");
                }
                    
                
            }
            
           
            //ålder 11 - 15
            else if (age <= 15 && age >= 11)
            {
                if (medOk.IsChecked == true)
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år gammal och då får du se filmer med åldersgräns upp till 11 år oavsätt om en vuxen är med.");
                }
                else if (utanOk.IsChecked == true)
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år gammal och då får du se filmer med åldersgräns upp till 11 år");

                }
            }



            //ålder 7 - 11
            else if (age <= 11 && age >= 7)
            {
                if (medOk.IsChecked == true)
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år gammal och får se alla filmer med åldersgräns 11 år eftersom du är i vuxet sällskap.");
                }
                
                else if (utanOk.IsChecked == true)
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år gammal och får se alla filmer med åldersgräns 7 år.");
                }   
            }
            
            
            //ålder 1 - 7
            else if (age <= 7 && age >= 1)
            {
                if (medOk.IsChecked == true)
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år gammal och får se filmer upp till 11 år i vuxet sällskap.");

                }

                else if (utanOk.IsChecked == true)
                {
                    svarBlock.Text = Convert.ToString("Hej " + name + ". Du är " + age + " år gammal och får se alla barntillåtna filmer.");

                }
            }
            
            
            //utan ålder
            else
            {
                svarBlock.Text = Convert.ToString("Du måste skriva in ett ålder.");
            }
        }

        private void medOk_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
