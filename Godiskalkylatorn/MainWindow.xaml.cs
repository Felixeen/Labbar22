using System;
using System.Collections.Generic;
using System.IO;
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
        CandyCalculator candyCalculator = new CandyCalculator();
        
        
        public MainWindow()
        {
            
            InitializeComponent();
            CheckJSON();
            //fokuserar på första textrutan när programmet startas
            fNameBox.Focus();
            
        }

        public void Clear()
        {
            //tar bort tidigare text i textrutorna
            fNameBox.Clear();
            lNameBox.Clear();
            ageBox.Clear();

            //fokuserar på första textrutan igen
            fNameBox.Focus();
        }

        //lägg till en ny person
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            


            

            string firstName = fNameBox.Text;
            string lastName = lNameBox.Text;
            int age = int.Parse(ageBox.Text);


            AddPerson(firstName, lastName, age);


            personListBox.ItemsSource = null;

            personListBox.ItemsSource = candyCalculator.Members;

            Clear();

        }
        //inkapsling
        public void AddPerson(string inputFirst, string inputLast, int inputAge)
        {
            Person person = new Person();
            person.FirstName = inputFirst;
            person.LastName = inputLast;
            person.Age = inputAge;

            candyCalculator.Members.Add(person);
        }
        
        //fördela metod
        public void okBtn_Click(object sender, RoutedEventArgs e)
        {

            int candies = int.Parse(godisBox.Text);
            
            candyCalculator.DistributeCandies(candies);

            personListBox.ItemsSource = null;
            personListBox.ItemsSource = candyCalculator.Members;

            //Sparar till JSON
            SaveJSON();

        }

        
        

        //radioknapparna för förnamn, efternamn och ålder
        private void radioLastName_Checked(object sender, RoutedEventArgs e)
        {
            candyCalculator.SortByLastName();
            personListBox.ItemsSource = null;
            personListBox.ItemsSource = candyCalculator.Members;
        }

        private void radioFirstName_Checked(object sender, RoutedEventArgs e)
        {
            candyCalculator.SortByFirstName();
            personListBox.ItemsSource = null;
            personListBox.ItemsSource = candyCalculator.Members;
        }

        private void radioAge_Checked(object sender, RoutedEventArgs e)
        {
            candyCalculator.SortByAge();
            personListBox.ItemsSource = null;
            personListBox.ItemsSource = candyCalculator.Members;
        }


        //metoden för att kolla JSON-filen från tidigare session
        private void CheckJSON()
        {
            string fileName = "CandyCalculator.json";
            if (File.Exists(fileName))
            {
                candyCalculator = FileHandler.Open<CandyCalculator>(fileName);

                personListBox.ItemsSource = null;
                personListBox.ItemsSource = candyCalculator.Members;
            }
            else
            {
                personListBox.ItemsSource = null;
                personListBox.ItemsSource = candyCalculator.Members;
            }
        }
        //metoden för att spara JSON-filen
        private void SaveJSON()
        {
            string fileName = "CandyCalculator.json";
            FileHandler.Save(candyCalculator, fileName);
        }
        


        

    }
}
