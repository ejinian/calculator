using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightSteelBlue;
        }

        string operation;
        string firstNumber = "";
        string secondNumber = "";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            secondNumber = textBox1.Text;
            if (string.IsNullOrEmpty(secondNumber.Trim()))
            {
                return;
            }

            if (operation == "x")
            {
                try
                {
                    double result = double.Parse(firstNumber) * double.Parse(secondNumber);
                    textBox1.Text = result.ToString();
                }
                catch
                {
                    textBox1.Text = "0";
                    MessageBox.Show("Nice try boyyyyy I got this one covered too");
                }

            }
            if (operation == "/")
            {
                if (double.Parse(secondNumber) == 0)
                {
                    textBox1.Clear();
                    MessageBox.Show("Nice try. You cannot divide by zero.");
                    textBox1.Text = "0";
                }
                else
                {
                    double result = double.Parse(firstNumber) / double.Parse(secondNumber);
                    textBox1.Text = result.ToString();
                }
            }
            if (operation == "+")
            {
                double result = double.Parse(firstNumber) + double.Parse(secondNumber);
                textBox1.Text = result.ToString();
            }
            if (operation == "-")
            {
                double result = double.Parse(firstNumber) - double.Parse(secondNumber);
                textBox1.Text = result.ToString();
            }
            if (operation == "√")
            {
                double result = Math.Sqrt(double.Parse(secondNumber));
                textBox1.Text = result.ToString();
            }
            operation = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation))
            {
                secondNumber = textBox1.Text;
                if (string.IsNullOrEmpty(secondNumber.Trim()))
                {
                    return;
                }

                if (operation == "+")
                {
                    firstNumber = (double.Parse(firstNumber) + double.Parse(secondNumber)).ToString();
                }
                if (operation == "-")
                {
                    firstNumber = (double.Parse(firstNumber) - double.Parse(secondNumber)).ToString();
                }
                if (operation == "x")
                {
                    firstNumber = (double.Parse(firstNumber) * double.Parse(secondNumber)).ToString();
                }
                if (operation == "/")
                {
                    firstNumber = (double.Parse(firstNumber) / double.Parse(secondNumber)).ToString();
                }
            }
            else
            {
                firstNumber = textBox1.Text;
            }
            operation = "x";

            textBox1.Text = String.Empty;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation))
            {
                secondNumber = textBox1.Text;
                if (string.IsNullOrEmpty(secondNumber.Trim()))
                {
                    return;
                }

                if (operation == "+")
                {
                    firstNumber = (double.Parse(firstNumber) + double.Parse(secondNumber)).ToString();
                }
                if (operation == "-")
                {
                    firstNumber = (double.Parse(firstNumber) - double.Parse(secondNumber)).ToString();
                }
                if (operation == "x")
                {
                    firstNumber = (double.Parse(firstNumber) * double.Parse(secondNumber)).ToString();
                }
                if (operation == "/")
                {
                    firstNumber = (double.Parse(firstNumber) / double.Parse(secondNumber)).ToString();
                }
                if (operation == "√")
                {
                    firstNumber = Math.Sqrt(double.Parse(secondNumber)).ToString();
                }
            }
            else
            {
                firstNumber = textBox1.Text;
            }
            operation = "/";

            textBox1.Text = String.Empty;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation))
            {
                secondNumber = textBox1.Text;
                if (string.IsNullOrEmpty(secondNumber.Trim()))
                {
                    return;
                }

                if (operation == "+")
                {
                    firstNumber = (double.Parse(firstNumber) + double.Parse(secondNumber)).ToString();
                }
                if (operation == "-")
                {
                    firstNumber = (double.Parse(firstNumber) - double.Parse(secondNumber)).ToString();
                }
                if (operation == "x")
                {
                    firstNumber = (double.Parse(firstNumber) * double.Parse(secondNumber)).ToString();
                }
                if (operation == "/")
                {
                    firstNumber = (double.Parse(firstNumber) / double.Parse(secondNumber)).ToString();
                }
            }
            else
            {
                firstNumber = textBox1.Text;
            }
            operation = "-";

            textBox1.Text = String.Empty;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation))
            {
                secondNumber = textBox1.Text;
                if (string.IsNullOrEmpty(secondNumber.Trim()))
                {
                    return;
                }

                if (operation == "+")
                {
                    firstNumber = (double.Parse(firstNumber) + double.Parse(secondNumber)).ToString();
                }
                if (operation == "-")
                {
                    firstNumber = (double.Parse(firstNumber) - double.Parse(secondNumber)).ToString();
                }
                if (operation == "x")
                {
                    firstNumber = (double.Parse(firstNumber) * double.Parse(secondNumber)).ToString();
                }
                if (operation == "/")
                {
                    firstNumber = (double.Parse(firstNumber) / double.Parse(secondNumber)).ToString();
                }
            }
            else
            {
                firstNumber = textBox1.Text;
            }

            textBox1.Text = String.Empty;
            operation = "+";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            operation = String.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589";
        }


        private void button13_Click(object sender, EventArgs e)
        {
            operation = "√";
            firstNumber = textBox1.Text;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Control.DefaultBackColor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void clear_MouseLeave(object sender, MouseEventArgs e)
        {
            clear.BackColor = Control.DefaultBackColor;
        }

        private void clear_MouseEnter(object sender, EventArgs e)
        {
            clear.BackColor = Color.Gold;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button2_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Control.DefaultBackColor;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Control.DefaultBackColor;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Control.DefaultBackColor;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Control.DefaultBackColor;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Control.DefaultBackColor;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Control.DefaultBackColor;
        }

        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clear.BackColor = Control.DefaultBackColor;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Control.DefaultBackColor;
        }

        private void button0_MouseEnter(object sender, EventArgs e)
        {
            button0.BackColor = Color.White;
        }

        private void button0_MouseLeave(object sender, EventArgs e)
        {
            button0.BackColor = Control.DefaultBackColor;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Control.DefaultBackColor;
        }

        private void submit_MouseEnter(object sender, EventArgs e)
        {
            submit.BackColor = Color.LightBlue;
        }

        private void submit_MouseLeave(object sender, EventArgs e)
        {
            submit.BackColor = Control.DefaultBackColor;
        }

        private void plusButton_MouseEnter(object sender, EventArgs e)
        {
            plusButton.BackColor = Color.Silver;
        }

        private void plusButton_MouseLeave(object sender, EventArgs e)
        {
            plusButton.BackColor = Control.DefaultBackColor;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            delButton.BackColor = Color.Red;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            delButton.BackColor = Control.DefaultBackColor;
        }

        private void minusButton_MouseEnter(object sender, EventArgs e)
        {
            minusButton.BackColor = Color.Silver;
        }

        private void minusButton_MouseLeave(object sender, EventArgs e)
        {
            minusButton.BackColor = Control.DefaultBackColor;
        }

        private void piButton_MouseEnter(object sender, EventArgs e)
        {
            piButton.BackColor = Color.Silver;
        }

        private void piButton_MouseLeave(object sender, EventArgs e)
        {
            piButton.BackColor = Control.DefaultBackColor;
        }

        private void multiplyButton_MouseEnter(object sender, EventArgs e)
        {
            multiplyButton.BackColor = Color.Silver;
        }

        private void multiplyButton_MouseLeave(object sender, EventArgs e)
        {
            multiplyButton.BackColor = Control.DefaultBackColor;
        }

        private void sqrtButton_MouseEnter(object sender, EventArgs e)
        {
            sqrtButton.BackColor = Color.Silver;
        }

        private void sqrtButton_MouseLeave(object sender, EventArgs e)
        {
            sqrtButton.BackColor = Control.DefaultBackColor;
        }

        private void divideButton_MouseEnter(object sender, EventArgs e)
        {
            divideButton.BackColor = Color.Silver;
        }

        private void divideButton_MouseLeave(object sender, EventArgs e)
        {
            divideButton.BackColor = Control.DefaultBackColor;
        }

        private void dotButton_MouseEnter(object sender, EventArgs e)
        {
            dotButton.BackColor = Color.Silver;
        }

        private void dotButton_MouseLeave(object sender, EventArgs e)
        {
            dotButton.BackColor = Control.DefaultBackColor;
        }

        private void delButton_MouseClick(object sender, MouseEventArgs e)
        {
            delButton.BackColor = Color.Blue;
            string originalString = textBox1.Text;
            if (originalString.Length != 0 && originalString != "0")
            {
                string oneLetterDown = String.Empty;
                int number = 0;
                int index = 1;
                do
                {
                    oneLetterDown = originalString.Substring(0, originalString.Length - index);
                    index++;
                }
                while (oneLetterDown.Length > 0 && !int.TryParse(oneLetterDown[oneLetterDown.Length - 1].ToString(), out number));

                textBox1.Text = oneLetterDown;

                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }

                if (string.IsNullOrEmpty(oneLetterDown.Trim()))
                {
                    return;
                }
            }
        }

        private void clear_MouseClick(object sender, MouseEventArgs e)
        {
            clear.BackColor = Color.Red;
        }

        private void submit_MouseClick(object sender, MouseEventArgs e)
        {
            submit.BackColor = Color.Yellow;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                textBox1.Text += "1";
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                textBox1.Text += "2";
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                textBox1.Text += "3";
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                textBox1.Text += "4";
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                textBox1.Text += "5";
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                textBox1.Text += "6";
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                textBox1.Text += "7";
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                textBox1.Text += "8";
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                textBox1.Text += "9";
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                textBox1.Text += "0";
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += ".";
                }
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }




    }
}

