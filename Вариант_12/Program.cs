using System;

class Program
{
    static void Main()
    {
        // Вариант 12. Сгенерировать ближайшее простое число (большее введенного)
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        int nextNumber = number + 1;
        if (nextNumber < 2)
        {
            nextNumber = 2;
        }

        while (true)
        {
            bool isPrime = true;

            for (int i = 2; i < nextNumber; i++)
            {
                if (nextNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Ближайшее простое число: " + nextNumber);
                break;
            }

            nextNumber = nextNumber + 1;
        }
    }
}
