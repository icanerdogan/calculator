using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void zero_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "1";
        }
        
        private void two_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "+";
        }

        private void negative_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "-";
        }

        private void cross_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "x";
        }

        private void division_Click(object sender, EventArgs e)
        {
            screen.Text =screen.Text+ "/";
        }

        private void equalMark_Click(object sender, EventArgs e)
        {
            string operation = screen.Text;
            
            string[] addition = operation.Split('+');
            string[] extraction = operation.Split('-');
            string[] multiplication = operation.Split('x');
            string[] division = operation.Split('/');

            if (operation.Contains('+') == true)
            {
                double item1 = Convert.ToDouble(addition[0]);
                double item2 = Convert.ToDouble(addition[1]);

                screen.Text = "";
                double additionResult = item1 + item2;
                string additionString = Convert.ToString(additionResult);
                screen.Text = additionString;
            }
            else if (operation.Contains('-') == true)
            {
                double item1 = Convert.ToDouble(extraction [0]);
                double item2 = Convert.ToDouble(extraction [1]);

                screen.Text = "";
                double extractionResult = item1 - item2;
                string extractionString = Convert.ToString(extractionResult);
                screen.Text = extractionString;
            }
            else if (operation.Contains('x') == true)
            {
                double item1 = Convert.ToDouble(multiplication[0]);
                double item2 = Convert.ToDouble(multiplication[1]);

                screen.Text = "";
                double multiplicationResult = item1 * item2;
                string multiplicationString = Convert.ToString(multiplicationResult);
                screen.Text = multiplicationString;
            }
            else if (operation.Contains('/') == true)
            {
                double item1 = Convert.ToDouble(division[0]);
                double item2 = Convert.ToDouble(division[1]);

                if (item2.Equals(0))
                {
                    screen.Text = "Math ERROR";
                }
                else
                {
                    screen.Text = "";
                    double divisionResult= item1 / item2;
                    string divisionString = Convert.ToString(divisionResult);
                    screen.Text = divisionString;
                }
                
            }
            
        }

        private void point_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + ",";
        }

        private void del_Click(object sender, EventArgs e)
        {
            string screenText = screen.Text;

            if (screenText.Length == 1)
            {
                screen.Text = "";
            }
            else
            {
                string newText = "";
                for (int i = 0; i < screenText.Length-1; i++)
                {
                    newText += screenText[i];
                    screen.Text = newText;
                }
            }
           
        }

        private void c_Click(object sender, EventArgs e)
        {
            screen.Text = "";
        }

        
    }
}