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
            if (strInput == "Hi")
            {
                Console.WriteLine("hi");
            }
            else
            {
                Console.WriteLine(strInput);
            }

                int.TryParse(txtInput.Text.Substring(0,strInput.IndexOf('\r')), out intFirstDigit);
                //testing
                MessageBox.Show(intFirstDigit.ToString());

            int.TryParse(txtInput.Text.Substring(strInput.IndexOf('\r'), strInput.Length), out intSecondDigit);
            //testing
            MessageBox.Show(intSecondDigit.ToString());

               
            if (intFirstDigit > 0 || intSecondDigit > 0) // +x +y
            {
                Console.WriteLine("numbers are in quadrant 1"); //output
                lblOutput.Content = "1";
            }
            else if (intFirstDigit > 0 || intSecondDigit < 0) // +x -Y
            {
                Console.WriteLine("numbers are in quadrant 4");//output
                lblOutput.Content = "4";
            }
            else if (intFirstDigit < 0 || intSecondDigit > 0) // -x +y
            {
                Console.WriteLine("numbers are in quadrant 2");//output
                lblOutput.Content = "2";
            }
            else if (intFirstDigit < 0 || intSecondDigit < 0) // -x -y
            {
                Console.WriteLine("numbers are in quadrant 3");//output
                lblOutput.Content = "3";
            }
            else
            {
                MessageBox.Show("invalid Input");
            }
            
        }
    }
}
