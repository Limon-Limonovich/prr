using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

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
            int digit = number % 10;
            sum = sum + digit;
            count = count + 1;
            number = number / 10;
        }

        double average = (double)sum / count;
        Console.WriteLine("Среднее арифметическое цифр числа: " + average);
    }
}
