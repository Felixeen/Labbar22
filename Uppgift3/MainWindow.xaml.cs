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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift3
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
            if (btnOne.Content == "Oklickad")
            {
                btnOne.Content = "Klickad";
                btnOne.Effect = new DropShadowEffect();
               
            }
            else
            {
                btnOne.Content = "Oklickad";

                btnOne.Effect = null;
            }


        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (btnTwo.Content == "Oklickad")
            {
                btnTwo.Content = "Klickad";
                btnTwo.Effect = new DropShadowEffect();
            }
            else
            {
                btnTwo.Content = "Oklickad";
                btnTwo.Effect = null;
            }

        }
    }
}
