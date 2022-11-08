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

namespace Uppgift8
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {


            //convert text from testbox to int 
            int tal1 = int.Parse(talBox1.Text);
            int tal2 = int.Parse(talBox2.Text);

            int sum = tal1 / tal2;
            int rest = tal1 % tal2;



            //show result in textbox text
            sumBox.Text = sum.ToString();
            restBox.Text = rest.ToString();


            
            //for (int i = tal1; i <= tal2; i++)
            //{
            //    int sum = i / tal2;
            //    int rest = i % tal2;



            
        }
    }
}
