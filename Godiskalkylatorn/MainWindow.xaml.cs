using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Godiskalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //fokuserar på första textrutan när programmet startas
            fNameBox.Focus();
            
        }

        

        public void addBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Person person = new Person();
            
            person.FirstName = fNameBox.Text;
            person.LastName = lNameBox.Text;
            person.Age = int.Parse(ageBox.Text);


            personListBox.Items.Add(person.FirstName + " " + person.LastName + " (" + person.Age + " år):" + " " + person.Candies);






            //tar bort tidigare text i textrutorna
            fNameBox.Clear();
            lNameBox.Clear();
            ageBox.Clear();

            //fokuserar på första textrutan igen
            fNameBox.Focus();
        }



        public void okBtn_Click(object sender, RoutedEventArgs e)
        {
            //CandyCalculator candy = new CandyCalculator();

            //ta bort kan inte vara ny person
            Person person = new Person();
            person.Candies = int.Parse(godisBox.Text);

            //skriv ut candies i listbox på varje person ifrån candy calculator
            
            



        }
    }
}
