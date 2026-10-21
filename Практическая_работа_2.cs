using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ==================== Задание 6 (Анализ фрагментов кода) ====================
        Console.WriteLine("=== Задание 6. Проверка фрагментов кода ===");

        // Фрагмент 1
        {
            int a = 7, b = 2;
            Console.WriteLine("Фрагмент 1:");
            Console.WriteLine(a / b);
            Console.WriteLine((double)a / b);
        }

        // Фрагмент 2
        {
            int x = 5;
            Console.WriteLine("Фрагмент 2:");
            Console.WriteLine(x++);
            Console.WriteLine(++x);
            Console.WriteLine(x);
        }

        // Фрагмент 3
        {
            int x = 10;
            x += 5;
            x *= 2;
            x -= 3;
            Console.WriteLine("Фрагмент 3:");
            Console.WriteLine(x);
        }

        // Фрагмент 4
        {
            bool b = 5 > 3 && 2 != 2 || true;
            Console.WriteLine("Фрагмент 4:");
            Console.WriteLine(b);
        }

        // Фрагмент 5
        {
            string s = "5";
            int n = Convert.ToInt32(s) + 1;
            Console.WriteLine("Фрагмент 5:");
            Console.WriteLine(n);
        }

        // Фрагмент 6
        {
            int? q = null;
            Console.WriteLine("Фрагмент 6:");
            Console.WriteLine(q ?? 0);
            Console.WriteLine(q?.ToString() ?? "null");
        }

        // Фрагмент 7
        {
            Console.WriteLine("Фрагмент 7:");
            for (int i = 0; i < 5; i++)
            {
                if (i == 2) continue;
                if (i == 4) break;
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Фрагмент 8
        {
            Console.WriteLine("Фрагмент 8:");
            int i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            } while (i < 3);
            Console.WriteLine();
        }

        // Фрагмент 9
        {
            char c = 'B';
            int code = c;
            Console.WriteLine("Фрагмент 9:");
            Console.WriteLine(code);
        }

        // Фрагмент 10
        {
            decimal d = 0.1m + 0.2m;
            Console.WriteLine("Фрагмент 10:");
            Console.WriteLine(d == 0.3m);
        }
        Console.WriteLine();

        // ==================== Задание A. Обязательное для всех: «Анкета и ИМТ» ====================
        Console.WriteLine("=== Задание A. Анкета и ИМТ ===");

        // 1. Ввод имени пользователя (string)
        Console.Write("Введите ваше имя: ");
        string? userName = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("Ошибка: имя пользователя не может быть пустым.");
            return;
        }

        // 2. Ввод возраста (int) через TryParse
        Console.Write("Введите ваш возраст (полных лет): ");
        if (!int.TryParse(Console.ReadLine(), out int userAge) || userAge <= 0 || userAge > 130)
        {
            Console.WriteLine("Ошибка: введите корректный возраст (целое положительное число).");
            return;
        }

        // 3. Ввод роста в метрах (double) через TryParse
        Console.Write("Введите ваш рост в метрах (например, 1.75): ");
        string? heightInput = Console.ReadLine()?.Replace(',', '.');
        if (!double.TryParse(heightInput, NumberStyles.Float, CultureInfo.InvariantCulture, out double heightMeters)
            || heightMeters <= 0.4 || heightMeters > 2.6)
        {
            Console.WriteLine("Ошибка: введите корректный рост в метрах (например, 1.75).");
            return;
        }

        // 4. Ввод веса в килограммах (double) через TryParse
        Console.Write("Введите ваш вес в килограммах (например, 68.5): ");
        string? weightInput = Console.ReadLine()?.Replace(',', '.');
        if (!double.TryParse(weightInput, NumberStyles.Float, CultureInfo.InvariantCulture, out double weightKg)
            || weightKg <= 2.0 || weightKg > 500.0)
        {
            Console.WriteLine("Ошибка: введите корректный вес в килограммах.");
            return;
        }

        // 5. Вычисление ИМТ по формуле: ИМТ = вес / рост^2
        double bmi = weightKg / (heightMeters * heightMeters);

        // 6. Определение категории ИМТ
        string category;
        if (bmi < 18.5)
            category = "Недостаточная масса";
        else if (bmi < 25.0)
            category = "Норма";
        else if (bmi < 30.0)
            category = "Избыточная масса";
        else
            category = "Ожирение";

        // 7. Форматированный вывод результатов
        Console.WriteLine($"
Имя:       {userName}");
        Console.WriteLine($"Возраст:   {userAge}");
        Console.WriteLine($"ИМТ:       {bmi:F2}");
        Console.WriteLine($"Категория: {category}");

        // 8. Дополнительное сообщение для лиц младше 18 лет
        if (userAge < 18)
        {
            Console.WriteLine("Результат может быть неточным для лиц младше 18 лет");
        }
    }
}
