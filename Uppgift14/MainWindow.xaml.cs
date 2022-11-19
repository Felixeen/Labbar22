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
using System.Xml.Schema;

namespace Uppgift14
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
            talBox.Focus();

            double total = 0;
            double tal = double.Parse(talBox.Text);

            listBox.Items.Add(tal);

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                total = Convert.ToDouble(listBox.Items[i]) + total;
            }
            if (listBox.Items.Count > 4)
            {
                okBtn.IsEnabled = false;
            }

            
                midvalueBox.Text = (total / listBox.Items.Count).ToString();

            talBox.Clear();




            // ListBox number = new ListBox();

            // List<double> number = new List<double>();

            //listBox.Add(double.Parse(talBox.Text));



            //List<int> number = new List<int>();
            //List<int> number = new List<int> { listBox.Items.Value };





            //double[] sum = listBox.ToArray();

            //foreach (int i in a)
            //{
            //    MessageBox.Show (i.ToString());
            //}

            //double average = listBox.Count > 0 ? listBox.Average() : 0.0;
            //List<int> numbers = new List<int> { listBox.Items.Count };

            //double average = numbers.Count > 0 ? numbers.Average() : 0.0;
            //midvalueBox.Text = average.ToString();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {

            listBox.Items.Clear();
            midvalueBox.Text = String.Empty;
            talBox.Text = String.Empty;
            talBox.Focus();

            if (okBtn.IsEnabled == false)
            {
                okBtn.IsEnabled = true;
            }
            
        }
    }
}
