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
            // Задание 1. Описание переменных: две для операндов, одна для операции
            double firstOperand = 0;
            double secondOperand = 0;
            string operation = operationTextBox.Text.Trim();

            if (operation == "")
            {
                resultTextBox.Text = "Ошибка! Введите операцию";
                return;
            }

            if (!double.TryParse(firstOperandTextBox.Text.Trim(), out firstOperand))
            {
                resultTextBox.Text = "Ошибка! Некорректный первый операнд";
                return;
            }

            // Задание 3. Вычисление факториала (второй операнд не требуется)
            if (operation == "!")
            {
                long factorialNumber;
                if (!long.TryParse(firstOperandTextBox.Text.Trim(), out factorialNumber))
                {
                    resultTextBox.Text = "Ошибка! Введите целое число";
                    return;
                }

                if (factorialNumber < 0)
                {
                    resultTextBox.Text = "Ошибка! Число не может быть отрицательным";
                    return;
                }

                if (factorialNumber > 20)
                {
                    resultTextBox.Text = "Ошибка! Переполнение типа (макс. 20)";
                    return;
                }

                long factorialResult = 1;
                for (int i = 2; i <= factorialNumber; i++)
                {
                    factorialResult *= i;
                }

                resultTextBox.Text = factorialResult.ToString();
                return;
            }

            // Задание 4 (Вариант 11). Подсчет среднего арифметического цифр числа (второй операнд не требуется)
            if (operation == "avg" || operation == "ср")
            {
                long inputNumber;
                if (!long.TryParse(firstOperandTextBox.Text.Trim(), out inputNumber))
                {
                    resultTextBox.Text = "Ошибка! Введите целое число";
                    return;
                }

                long remainingDigits = Math.Abs(inputNumber);
                if (remainingDigits == 0)
                {
                    resultTextBox.Text = "0";
                    return;
                }

                long digitSum = 0;
                int digitCount = 0;

                while (remainingDigits > 0)
                {
                    long currentDigit = remainingDigits % 10;
                    digitSum += currentDigit;
                    digitCount++;
                    remainingDigits /= 10;
                }

                double averageDigit = (double)digitSum / digitCount;
                resultTextBox.Text = averageDigit.ToString();
                return;
            }

            // Задание 2. Основные арифметические операции (+, -, *, /)
            if (!double.TryParse(secondOperandTextBox.Text.Trim(), out secondOperand))
            {
                resultTextBox.Text = "Ошибка! Некорректный второй операнд";
                return;
            }

            double calculationResult = 0;

            if (operation == "+")
            {
                calculationResult = firstOperand + secondOperand;
                resultTextBox.Text = calculationResult.ToString();
            }
            else if (operation == "-")
            {
                calculationResult = firstOperand - secondOperand;
                resultTextBox.Text = calculationResult.ToString();
            }
            else if (operation == "*")
            {
                calculationResult = firstOperand * secondOperand;
                resultTextBox.Text = calculationResult.ToString();
            }
            else if (operation == "/")
            {
                if (secondOperand == 0)
                {
                    resultTextBox.Text = "Ошибка! Деление на 0";
                }
                else
                {
                    calculationResult = firstOperand / secondOperand;
                    resultTextBox.Text = calculationResult.ToString();
                }
            }
            else
            {
                resultTextBox.Text = "Ошибка! Неизвестная операция";
            }
        }
    }
}
