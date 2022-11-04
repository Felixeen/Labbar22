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

namespace Uppgift5
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

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            double numOne = Convert.ToDouble(txtBox.Text);
            double numTwo = Convert.ToDouble(txtBox2.Text);

            double sum = numOne + numTwo;

            txtBox3.Text = sum.ToString();
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
        }
    }
}
