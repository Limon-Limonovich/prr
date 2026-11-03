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

            // Задание 4 (Вариант 12). Ближайшее простое число, большее введенного (второй операнд не требуется)
            if (operation == "prime" || operation == "пр")
            {
                long inputNumber;
                if (!long.TryParse(firstOperandTextBox.Text.Trim(), out inputNumber))
                {
                    resultTextBox.Text = "Ошибка! Введите целое число";
                    return;
                }

                if (inputNumber >= long.MaxValue - 1000)
                {
                    resultTextBox.Text = "Ошибка! Слишком большое число";
                    return;
                }

                long candidateNumber = inputNumber < 2 ? 2 : inputNumber + 1;
                bool isPrimeFound = false;

                while (!isPrimeFound)
                {
                    bool isCurrentPrime = true;

                    for (long i = 2; i * i <= candidateNumber; i++)
                    {
                        if (candidateNumber % i == 0)
                        {
                            isCurrentPrime = false;
                            break;
                        }
                    }

                    if (isCurrentPrime)
                    {
                        isPrimeFound = true;
                    }
                    else
                    {
                        candidateNumber++;
                    }
                }

                resultTextBox.Text = candidateNumber.ToString();
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
