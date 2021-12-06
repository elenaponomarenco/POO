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

namespace Laborator_9
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

        private void Button_ok_Click(object sender, RoutedEventArgs e)
        {
            /*
            int nr1 = Convert.ToInt32(input_nr_1.Text);
            int nr2 = Convert.ToInt32(input_nr_2.Text);
            float division = (float)nr1 / (float)nr2;

            result.Text = String.Format("{0:0.00}", division).ToString();
            */
            
             string input_nr1 = Convert.ToString(input_nr_1.Text);
             string input_nr2 = Convert.ToString(input_nr_2.Text);
             if (!string.IsNullOrEmpty(input_nr1) || string.IsNullOrEmpty(input_nr2))
             {
                 int nr1 = 0;
                 int nr2 = 0;
                 string input_Nr1 = input_nr_1.Text;
                 string input_Nr2 = input_nr_2.Text;

                 if (String.IsNullOrEmpty(input_Nr1))
                 {
                     text1_err.Text = "Introdu un numar!";
                 }
                 else
                 {
                     nr1 = Convert.ToInt32(input_nr_1.Text);
                 }

                 if (String.IsNullOrEmpty(input_Nr2))
                 {
                     text2_err.Text = "Introdu un numar!";
                 }
                 else
                 {
                     nr2 = Convert.ToInt32(input_nr_2.Text);
                     if (nr2 == 0)
                     {
                         text2_err.Text = "Nu se imparte la 0!";
                     }
                     else if(nr2 == 13)
                     {
                         text2_err.Text = "13 este numar nenorocos!";
                     }
                 }
                 if (nr2 != 13)
                 {
                    float division = (float)nr1 / (float)nr2;
                    result.Text = String.Format("{0:0.00}", division).ToString();

                 }
                 
             } 
             else
             {
                 Empty_Fields.Text = "Nu a fost introdus nimic";
             }
            
        }
    }
}