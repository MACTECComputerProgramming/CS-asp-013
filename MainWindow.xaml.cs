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

namespace CS_ASP_013
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            comparisonLabel.Content = "Is Greater Than";
        }

        private void gobutton_Click(object sender, RoutedEventArgs e)
        {
            //  resultlabel.Content = (textBox1.Text == textBox2.Text) ? "yes" : "no";

            // resultlabel.Content = (oldcheckBox.IsChecked == true) ? "Hey kid, get off my lawn!" : "I need a new skateboard!";

            //resultlabel.Content = (textBox1.Text != textBox2.Text) ? "Yes" : "No";

            //int numOne = Convert.ToInt32(textBox1.Text);
            //int numTwo = Convert.ToInt32(textBox2.Text);


            //resultlabel.Content = (numOne > numTwo) ? "yes" : "no";

            if ((textBox1.Text == "Smith")||
                (textBox2.Text == "Wilson"))
            {
                resultlabel.Content = "Good Morning";
            }
            else
            {
                resultlabel.Content = "Who Are You?";
            }
        }
    }
}
