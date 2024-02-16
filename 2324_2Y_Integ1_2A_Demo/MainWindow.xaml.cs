using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace _2324_2Y_Integ1_2A_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] btnNums = new Button[10];
        double num1 = 0;
        double num2 = 0;
        int ope = -1;

        public MainWindow()
        {
            InitializeComponent();

            btnNums[0] = btn0;
            btnNums[1] = btn1;
            btnNums[2] = btn2;
            btnNums[3] = btn3;
            btnNums[4] = btn4;
            btnNums[5] = btn5;
            btnNums[6] = btn6;
            btnNums[7] = btn7;
            btnNums[8] = btn8;
            btnNums[9] = btn9;

            for (int x = 0; x < btnNums.Length; x++)
                btnNums[x].Content = x;

            btnAdd.Content = "+";
            btnMin.Content = "-";
            btnMult.Content = "x";
            btnDiv.Content = "/";
            btnEnter.Content = "=";
            btnSqr.Content = "x^2";
            btnSqrt.Content = "\u221A";
        }

        private void repeatchecker(double num1)
        {
            string nums = num1.ToString();
            if (nums.Contains("."))
            {
                string[] numssplit = nums.Split('.');
                for (int i = 0; i < numssplit.Length; i++)
                {
                    if (numssplit[1].Length > 5)
                    {
                        numssplit[1] = numssplit[1].Substring(0, 5);
                    }
                }
                nums = numssplit[0] + "." + numssplit[1];
                tbCalc.Text = nums;
            }
            else
            {
                tbCalc.Text = nums;
            }
        }

        private void numberEnter(int x)
        {
            string input = tbCalc.Text;
            input += x;

            if(input.Length > 5 )
                input = input.Substring(1);

            if (ope == -1)
            {

                num1 = int.Parse(input);

            }

            else
                num2 = int.Parse(input);

            tbCalc.Text = input;
        }
        
        private bool isnegativepositive()
        {
            //int inputnum = num * -1;
            
            return true;
        }

        #region KeypadEvents
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(9);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(8);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(7);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(6);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(5);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(4);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(3);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(2);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            numberEnter(1);
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            numberEnter(0);

        }
        private void btnPosiNega_Click(object sender, RoutedEventArgs e)
        {
            //isnegativepositive();
            


        }

        #endregion

        #region OperationEvents
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ope = 0;
            tbCalc.Text = "";
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            ope = 1;
            tbCalc.Text = "";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            ope = 2;
            tbCalc.Text = "";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            ope = 3;
            tbCalc.Text = "";
        }
        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            num1 = Math.Sqrt(num1);
            repeatchecker(num1);
        }
        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            num1 *= num1;
            repeatchecker(num1);
            
        }
        #endregion

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            switch(ope)
            {
                case 0:
                    num1 += num2;
                    break;
                case 1:
                    num1 -= num2;
                    break;
                case 2:
                    num1 *= num2;
                    break;
                case 3:
                    num1 /= num2;
                    break;
            }
            
            if(ope > -1)
            {
               // string nums = num1.ToString();
                repeatchecker(num1);
                
                //if (num1.ToString().Length < 5)
                //{
                //    tbCalc.Text = num1.ToString();
                //}
                //else
                //{
                //    tbCalc.Text = num1.ToString().Substring(0, 5);
                //}
                ope = -1;
                num2 = 0;
            }
        }
    }
}
