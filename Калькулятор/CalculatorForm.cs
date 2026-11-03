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
        }
    }
}
