using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double firstOperand = double.Parse(firstOperandTextBox.Text);
            double secondOperand = 0;
            if (secondOperandTextBox.Text != "")
            {
                secondOperand = double.Parse(secondOperandTextBox.Text);
            }
            string operation = operationTextBox.Text;

            if (operation == "+")
            {
                resultTextBox.Text = (firstOperand + secondOperand).ToString();
            }
            else if (operation == "-")
            {
                resultTextBox.Text = (firstOperand - secondOperand).ToString();
            }
            else if (operation == "*")
            {
                resultTextBox.Text = (firstOperand * secondOperand).ToString();
            }
            else if (operation == "/")
            {
                if (secondOperand == 0)
                {
                    resultTextBox.Text = "Ошибка! Деление на 0";
                }
                else
                {
                    resultTextBox.Text = (firstOperand / secondOperand).ToString();
                }
            }
            else if (operation == "!")
            {
                if (firstOperand < 0)
                {
                    resultTextBox.Text = "Ошибка! Отрицательное число";
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= firstOperand; i++)
                    {
                        factorial = factorial * i;
                    }
                    resultTextBox.Text = factorial.ToString();
                }
            }
            else if (operation == "avg")
            {
                int number = (int)firstOperand;
                if (number < 0)
                {
                    number = -number;
                }

                int sum = 0;
                int count = 0;

                if (number == 0)
                {
                    count = 1;
                }

                while (number > 0)
                {
                    sum = sum + number % 10;
                    count = count + 1;
                    number = number / 10;
                }

                double average = (double)sum / count;
                resultTextBox.Text = average.ToString();
            }
        }
    }
}
