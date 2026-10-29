using System;

class Program
{
    static void Main()
    {
        // Задание 6. Анализ фрагментов кода
        // Фрагмент 1
        int a = 7, b = 2;
        Console.WriteLine(a / b);
        Console.WriteLine((double)a / b);

        // Фрагмент 2
        int x2 = 5;
        Console.WriteLine(x2++);
        Console.WriteLine(++x2);
        Console.WriteLine(x2);

        // Фрагмент 3
        int x3 = 10;
        x3 += 5;
        x3 *= 2;
        x3 -= 3;
        Console.WriteLine(x3);

        // Фрагмент 4
        bool b4 = 5 > 3 && 2 != 2 || true;
        Console.WriteLine(b4);

        // Фрагмент 5
        string s5 = "5";
        int n5 = Convert.ToInt32(s5) + 1;
        Console.WriteLine(n5);

        // Фрагмент 6
        int? q = null;
        Console.WriteLine(q ?? 0);
        Console.WriteLine(q?.ToString() ?? "null");

        // Фрагмент 7
        for (int i = 0; i < 5; i++)
        {
            if (i == 2) continue;
            if (i == 4) break;
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Фрагмент 8
        int i8 = 0;
        do
        {
            Console.Write(i8 + " ");
            i8++;
        } while (i8 < 3);
        Console.WriteLine();

        // Фрагмент 9
        char c9 = 'B';
        int code9 = c9;
        Console.WriteLine(code9);

        // Фрагмент 10
        decimal d10 = 0.1m + 0.2m;
        Console.WriteLine(d10 == 0.3m);

        // Задание A. Обязательное для всех: «Анкета и ИМТ»
        Console.Write("Введите имя пользователя: ");
        string name = Console.ReadLine();

        Console.Write("Введите возраст: ");
        if (!int.TryParse(Console.ReadLine(), out int age) || age <= 0)
        {
            Console.WriteLine("Ошибка: введён некорректный возраст.");
            return;
        }

        Console.Write("Введите рост в метрах (например, 1,75): ");
        if (!double.TryParse(Console.ReadLine(), out double height) || height <= 0)
        {
            Console.WriteLine("Ошибка: введён некорректный рост.");
            return;
        }

        Console.Write("Введите вес в килограммах (например, 70): ");
        if (!double.TryParse(Console.ReadLine(), out double weight) || weight <= 0)
        {
            Console.WriteLine("Ошибка: введён некорректный вес.");
            return;
        }

        // Вычисление ИМТ
        double bmi = weight / (height * height);

        // Определение категории
        string category;
        if (bmi < 18.5)
        {
            category = "Недостаточная масса";
        }
        else if (bmi < 25)
        {
            category = "Норма";
        }
        else if (bmi < 30)
        {
            category = "Избыточная масса";
        }
        else
        {
            category = "Ожирение";
        }

        // Вывод результатов
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine($"ИМТ: {bmi:F2}");
        Console.WriteLine("Категория: " + category);

        if (age < 18)
        {
            Console.WriteLine("Результат может быть неточным для лиц младше 18 лет");
        }
    }
}
