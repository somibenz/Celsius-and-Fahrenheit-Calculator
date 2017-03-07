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

namespace Celsius_and_Fahrenheit_correctone_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal celsius;
        decimal fahrenheit;
        decimal celResult;
        decimal fahResult;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)

        {
            try
            {
                // code to convert celsius to fahrenheit
                fahrenheit = Convert.ToDecimal(textBox1.Text) * 1.8M;
                fahResult = fahrenheit + 32;
                label1.Content = fahResult;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {   //code to convert fahrenheit to celsius
                celsius = Convert.ToDecimal(textBox.Text) - 32;
                celResult = celsius * 0.55M;
                label.Content = celResult;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
