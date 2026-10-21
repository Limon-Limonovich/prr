using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        // ==================== Вводное задание 1 ====================
        // Напишите программу, которая выводит на экран три строки:
        // Привет, мир! / Меня зовут [ваше имя] / Я начинаю изучать C#
        Console.WriteLine("=== Вводное задание 1 ===");
        Console.WriteLine("Привет, мир!");
        Console.WriteLine("Меня зовут Алексей");
        Console.WriteLine("Я начинаю изучать C#");
        Console.WriteLine();

        // ==================== Вводное задание 2 ====================
        // Создайте три переменные с разными типами данных и выведите их на экран
        Console.WriteLine("=== Вводное задание 2 ===");
        int age = 19;            // целое число
        string name = "Алексей"; // текст
        bool isStudent = true;   // true или false
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Студент? " + isStudent);
        Console.WriteLine();

        // ==================== Вводное задание 3 ====================
        // Программа просит ввести возраст двух людей и сравнивает их
        Console.WriteLine("=== Вводное задание 3 ===");
        Console.Write("Введите возраст первого человека: ");
        int age1 = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Введите возраст второго человека: ");
        int age2 = int.Parse(Console.ReadLine() ?? "0");
        bool isFirstOlder = age1 > age2;
        Console.WriteLine("Первый старше второго? " + isFirstOlder);
        Console.WriteLine();

        // ==================== Задание 1 ====================
        // Возведение в квадрат, куб и четвёртую степень (два знака после запятой)
        Console.WriteLine("=== Задание 1 ===");
        Console.Write("Введите целое число: ");
        int num1 = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"1. Квадрат числа: {Math.Pow(num1, 2):F2}");
        Console.WriteLine($"2. Куб числа: {Math.Pow(num1, 3):F2}");
        Console.WriteLine($"3. Четвёртая степень: {Math.Pow(num1, 4):F2}");
        Console.WriteLine();

        // ==================== Задание 2 ====================
        // Возведение основания в степень показателя
        Console.WriteLine("=== Задание 2 ===");
        Console.Write("Введите основание степени: ");
        double baseNum2 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите показатель степени: ");
        double expNum2 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        double powResult2 = Math.Pow(baseNum2, expNum2);
        Console.WriteLine($"Результат возведения в степень: {powResult2:F4}");
        Console.WriteLine();

        // ==================== Задание 3 ====================
        // Квадратный корень числа с проверкой на отрицательность
        Console.WriteLine("=== Задание 3 ===");
        Console.Write("Введите число для извлечения квадратного корня: ");
        double num3 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        if (num3 < 0)
        {
            Console.WriteLine("Невозможно вычислить квадратный корень из отрицательного числа.");
        }
        else
        {
            Console.WriteLine($"Квадратный корень: {Math.Sqrt(num3):F4}");
        }
        Console.WriteLine();

        // ==================== Задание 4 ====================
        // Кубический корень числа (включая отрицательные значения)
        Console.WriteLine("=== Задание 4 ===");
        Console.Write("Введите число (может быть отрицательным): ");
        double num4 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        double cubeRoot4 = num4 < 0 ? -Math.Pow(-num4, 1.0 / 3.0) : Math.Pow(num4, 1.0 / 3.0);
        Console.WriteLine($"Кубический корень: {cubeRoot4:F4}");
        Console.WriteLine();

        // ==================== Задание 5 ====================
        // Вычисление корня n-й степени
        Console.WriteLine("=== Задание 5 ===");
        Console.Write("Введите число: ");
        double num5 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите показатель корня n: ");
        int n5 = int.Parse(Console.ReadLine() ?? "1");
        if (num5 < 0 && n5 % 2 == 0)
        {
            Console.WriteLine("Невозможно вычислить корень чётной степени из отрицательного числа.");
        }
        else
        {
            double nthRoot5 = num5 < 0 ? -Math.Pow(-num5, 1.0 / n5) : Math.Pow(num5, 1.0 / n5);
            Console.WriteLine($"Корень {n5}-й степени: {nthRoot5:F4}");
        }
        Console.WriteLine();

        // ==================== Задание 6 ====================
        // Длина гипотенузы прямоугольного треугольника (округление до 3 знаков)
        Console.WriteLine("=== Задание 6 ===");
        Console.Write("Введите длину первого катета: ");
        double cathetusA = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите длину второго катета: ");
        double cathetusB = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        double hypotenuse = Math.Sqrt(Math.Pow(cathetusA, 2) + Math.Pow(cathetusB, 2));
        Console.WriteLine($"Длина гипотенузы: {Math.Round(hypotenuse, 3):F3}");
        Console.WriteLine();

        // ==================== Задание 7 ====================
        // Расстояние между двумя точками (x1, y1) и (x2, y2)
        Console.WriteLine("=== Задание 7 ===");
        Console.Write("Введите x1: ");
        double x1 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите y1: ");
        double y1 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите x2: ");
        double x2 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите y2: ");
        double y2 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Расстояние между точками: {distance:F4}");
        Console.WriteLine();

        // ==================== Задание 8 ====================
        // Площадь круга и длина окружности (с использованием Math.PI)
        Console.WriteLine("=== Задание 8 ===");
        Console.Write("Введите радиус круга: ");
        double radius = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.WriteLine("Math.PI = " + Math.PI);
        double circleArea = Math.PI * Math.Pow(radius, 2);
        double circleLength = 2 * Math.PI * radius;
        Console.WriteLine($"1. Площадь круга: {circleArea:F2}");
        Console.WriteLine($"2. Длина окружности: {circleLength:F2}");
        Console.WriteLine();

        // ==================== Задание 9 ====================
        // Сложный процент: S = P * (1 + r / 100)^t
        Console.WriteLine("=== Задание 9 ===");
        Console.Write("Введите начальную сумму вклада: ");
        double deposit = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите годовую процентную ставку (%): ");
        double rate = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите количество лет: ");
        int years = int.Parse(Console.ReadLine() ?? "0");
        double totalAmount = deposit * Math.Pow(1 + rate / 100.0, years);
        Console.WriteLine($"Итоговая сумма по сложному проценту: {totalAmount:F2}");
        Console.WriteLine();

        // ==================== Задание 10 ====================
        // Сравнение вычисления квадратного корня через Math.Sqrt() и Math.Pow(число, 0.5)
        Console.WriteLine("=== Задание 10 ===");
        Console.Write("Введите положительное число: ");
        double num10 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        double sqrtMethod1 = Math.Sqrt(num10);
        double sqrtMethod2 = Math.Pow(num10, 0.5);
        Console.WriteLine($"Через Math.Sqrt():        {sqrtMethod1}");
        Console.WriteLine($"Через Math.Pow(x, 0.5):   {sqrtMethod2}");
        Console.WriteLine($"Результаты совпадают?     {sqrtMethod1 == sqrtMethod2}");
        Console.WriteLine();

        // ==================== Задание 11 ====================
        // Таблица степеней числа от 1 до 10
        Console.WriteLine("=== Задание 11 ===");
        Console.Write("Введите число для таблицы степеней: ");
        double num11 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        for (int p = 1; p <= 10; p++)
        {
            Console.WriteLine($"Степень {p}: {Math.Pow(num11, p):F2}");
        }
        Console.WriteLine();

        // ==================== Задание 12 ====================
        // Найти x такое, что x^n = y, и проверить обратной операцией возведения в степень
        Console.WriteLine("=== Задание 12 ===");
        Console.Write("Введите число y: ");
        double y12 = double.Parse((Console.ReadLine() ?? "0").Replace(',', '.'));
        Console.Write("Введите показатель степени n: ");
        int n12 = int.Parse(Console.ReadLine() ?? "1");
        if (y12 < 0 && n12 % 2 == 0)
        {
            Console.WriteLine("Невозможно извлечь корень чётной степени из отрицательного числа.");
        }
        else
        {
            double x12 = y12 < 0 ? -Math.Pow(-y12, 1.0 / n12) : Math.Pow(y12, 1.0 / n12);
            double checkY12 = Math.Pow(x12, n12);
            Console.WriteLine($"Найденное x: {x12:F4}");
            Console.WriteLine($"Проверка (x^{n12}): {checkY12:F4}");
        }
    }
}
