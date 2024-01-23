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

namespace kalkulacka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string currentInput = "";
        private string currentOperator = "";
        private double result = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            currentOperator = button.Content.ToString();
            result = double.Parse(currentInput);
            currentInput = "";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "0";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "1";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "2";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "3";
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "4";
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "5";
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "6";
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "7";
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "8";
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textik.Text = textik.Text + "9";
        }
        
        
        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            textik.Text = "";
        }
        private void Button_Click_zpet(object sender, RoutedEventArgs e)
        {
            textik.Text = "";
        }

        private void Button_Click_cara(object sender, RoutedEventArgs e)
        {
            string hodnota = textik.Text;
            Boolean Found = false;
            for (int i = 0; i < hodnota.Length; i++)
            {
                if (hodnota[i] == ',')
                {
                    Found = true;
                }
            }
            if (!Found)
            {
                textik.Text += ",";
            }
        }
        
        private void Calculator()
        {

            double operand = double.Parse(currentInput);
            switch (currenOperator)
            {
                case "+":
                    result += operand;
                    break;
                case "-":
                    result -= operand;
                    break;
                case "*":
                    result *= operand;
                    break;
                case "/":
                    if (operand != 0)
                        result /= operand;
                    else
                        textik.Text = "Error";
                    break;
            }

        }
            
        
            


        private void Button_Click_nadruhou(object sender, RoutedEventArgs e)
        {
            double cislo = double.Parse(textik.Text);
            textik.Text = (cislo*cislo).ToString();
        }




    }

}
