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
        public MainWindow()
        {
            InitializeComponent();
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
            textik.Text = textik.Text + ",";
        }










    }

}
