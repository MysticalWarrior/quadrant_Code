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

namespace U2_j1_AidanM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput;
        int intFirstDigit = 69;
        int intSecondDigit = 69;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            string strInput = txtInput.Text;

            //Troubleshooting - shows index of \r
            int intIndexOfR = strInput.IndexOf('\r');
            Console.WriteLine(intIndexOfR.ToString());

            int.TryParse(txtInput.Text.Substring(0,strInput.IndexOf('\r')), out intFirstDigit);
            //testing
            Console.WriteLine("First Digit " + intFirstDigit.ToString());

            int.TryParse(txtInput.Text.Substring(strInput.IndexOf('\r')+2, strInput.Length - strInput.IndexOf('\r') - 2), out intSecondDigit);
            //testing
            Console.WriteLine("Second Digit " + intSecondDigit.ToString());

            // tryparses could also be done as: 
            ///strSecondDigit = txtinput.Text.Substring(txtInput.text.IndexOf('\r') + 2, txtInput.Text.Length - txtInput.Text.IndexOf('\r') - 2);
            ///int.tryparse(strSecondDigit, out y);

            if (intFirstDigit > 0) // +x
            {
                if (intSecondDigit > 0) // +y
                {
                    Console.WriteLine("numbers are in quadrant 1"); //output
                    lblOutput.Content = "1";
                }
                else if (intSecondDigit < 0) // -y
                {
                    Console.WriteLine("numbers are in quadrant 4");//output
                    lblOutput.Content = "4";
                }
            }
            else if (intFirstDigit < 0) // -x
            {
                if (intSecondDigit > 0) // +y
                {
                    Console.WriteLine("numbers are in quadrant 2");//output
                    lblOutput.Content = "2";
                }
                else if (intSecondDigit < 0) // -y
                {
                    Console.WriteLine("numbers are in quadrant 3");//output
                    lblOutput.Content = "3";
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            
        }
    }
}
