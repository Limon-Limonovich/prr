using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ==================== Разобранный пример: Шифр Цезаря (русский алфавит) ====================
        Console.WriteLine("=== Разобранный пример: Шифр Цезаря (русский алфавит) ===");
        Console.Write("Введите текст: ");
        string textRu = Console.ReadLine() ?? "";
        Console.Write("Введите сдвиг (например, 3): ");
        int shiftRu = int.Parse(Console.ReadLine() ?? "3");
        string encryptedRu = "";
        foreach (char c in textRu)
        {
            if (c >= 'а' && c <= 'я')
                encryptedRu += (char)('а' + (c - 'а' + shiftRu) % 32);
            else if (c >= 'А' && c <= 'Я')
                encryptedRu += (char)('А' + (c - 'А' + shiftRu) % 32);
            else
                encryptedRu += c;
        }
        Console.WriteLine("Зашифровано: " + encryptedRu);
        Console.WriteLine();

        // ==================== Задание 1 ====================
        // Шифр Цезаря только для английских букв (a–z, A–Z), 26 букв
        Console.WriteLine("=== Задание 1. Шифр Цезаря (английский алфавит) ===");
        Console.Write("Введите текст: ");
        string text1 = Console.ReadLine() ?? "";
        Console.Write("Введите сдвиг: ");
        int shift1 = int.Parse(Console.ReadLine() ?? "3");
        string encrypted1 = "";
        foreach (char c in text1)
        {
            if (c >= 'a' && c <= 'z')
                encrypted1 += (char)('a' + (c - 'a' + shift1) % 26);
            else if (c >= 'A' && c <= 'Z')
                encrypted1 += (char)('A' + (c - 'A' + shift1) % 26);
            else
                encrypted1 += c;
        }
        Console.WriteLine("Зашифровано: " + encrypted1);
        Console.WriteLine();

        // ==================== Задание 2 ====================
        // Расшифровка текста, зашифрованного шифром Цезаря (сдвиг влево)
        Console.WriteLine("=== Задание 2. Расшифровка шифра Цезаря ===");
        Console.Write("Введите шифртекст: ");
        string cipher2 = Console.ReadLine() ?? "";
        Console.Write("Введите сдвиг: ");
        int shift2 = int.Parse(Console.ReadLine() ?? "3");
        string decrypted2 = "";
        foreach (char c in cipher2)
        {
            if (c >= 'a' && c <= 'z')
                decrypted2 += (char)('a' + (c - 'a' - shift2 + 26) % 26);
            else if (c >= 'A' && c <= 'Z')
                decrypted2 += (char)('A' + (c - 'A' - shift2 + 26) % 26);
            else if (c >= 'а' && c <= 'я')
                decrypted2 += (char)('а' + (c - 'а' - shift2 + 32) % 32);
            else if (c >= 'А' && c <= 'Я')
                decrypted2 += (char)('А' + (c - 'А' - shift2 + 32) % 32);
            else
                decrypted2 += c;
        }
        Console.WriteLine("Расшифровано: " + decrypted2);
        Console.WriteLine();

        // ==================== Задание 3 ====================
        // Шифр Атбаш: каждая буква заменяется на «зеркальную» в алфавите (a <-> z, b <-> y)
        Console.WriteLine("=== Задание 3. Шифр Атбаш ===");
        Console.Write("Введите текст: ");
        string text3 = Console.ReadLine() ?? "";
        string encrypted3 = "";
        foreach (char c in text3)
        {
            if (c >= 'a' && c <= 'z')
                encrypted3 += (char)('z' - (c - 'a'));
            else if (c >= 'A' && c <= 'Z')
                encrypted3 += (char)('Z' - (c - 'A'));
            else if (c >= 'а' && c <= 'я')
                encrypted3 += (char)('я' - (c - 'а'));
            else if (c >= 'А' && c <= 'Я')
                encrypted3 += (char)('Я' - (c - 'А'));
            else
                encrypted3 += c;
        }
        Console.WriteLine("Зашифровано: " + encrypted3);
        Console.WriteLine();

        // ==================== Задание 4 ====================
        // Шифрование через операцию XOR (^) с ключом-числом
        Console.WriteLine("=== Задание 4. Шифрование XOR ===");
        Console.Write("Введите текст: ");
        string text4 = Console.ReadLine() ?? "";
        Console.Write("Введите ключ (число): ");
        int key4 = int.Parse(Console.ReadLine() ?? "42");
        string encrypted4 = "";
        foreach (char c in text4)
        {
            encrypted4 += (char)(c ^ key4);
        }
        Console.WriteLine("Зашифровано: " + encrypted4);
        string decrypted4 = "";
        foreach (char c in encrypted4)
        {
            decrypted4 += (char)(c ^ key4);
        }
        Console.WriteLine("Расшифровано (повторный XOR): " + decrypted4);
        Console.WriteLine();

        // ==================== Задание 5 ====================
        // Поменяйте местами каждые две соседние буквы
        Console.WriteLine("=== Задание 5. Перестановка соседних букв ===");
        Console.Write("Введите текст: ");
        string text5 = Console.ReadLine() ?? "";
        char[] chars5 = text5.ToCharArray();
        for (int i = 0; i < chars5.Length - 1; i += 2)
        {
            char temp = chars5[i];
            chars5[i] = chars5[i + 1];
            chars5[i + 1] = temp;
        }
        string encrypted5 = new string(chars5);
        Console.WriteLine("Зашифровано: " + encrypted5);
        Console.WriteLine();

        // ==================== Задание 6 ====================
        // Переверните строку задом наперёд
        Console.WriteLine("=== Задание 6. Переворот строки задом наперёд ===");
        Console.Write("Введите текст: ");
        string text6 = Console.ReadLine() ?? "";
        string encrypted6 = "";
        for (int i = text6.Length - 1; i >= 0; i--)
        {
            encrypted6 += text6[i];
        }
        Console.WriteLine("Зашифровано: " + encrypted6);
        Console.WriteLine();

        // ==================== Задание 7 ====================
        // Таблица замен (а->@, б->#, в->$ и т.д.)
        Console.WriteLine("=== Задание 7. Таблица замен ===");
        Console.Write("Введите текст: ");
        string text7 = Console.ReadLine() ?? "";
        string encrypted7 = "";
        foreach (char c in text7)
        {
            switch (char.ToLower(c))
            {
                case 'а': encrypted7 += '@'; break;
                case 'б': encrypted7 += '#'; break;
                case 'в': encrypted7 += '$'; break;
                case 'г': encrypted7 += '%'; break;
                case 'д': encrypted7 += '&'; break;
                case 'е': encrypted7 += '3'; break;
                case 'о': encrypted7 += '0'; break;
                case 'с': encrypted7 += '*'; break;
                default:  encrypted7 += c;   break;
            }
        }
        Console.WriteLine("Зашифровано: " + encrypted7);
        Console.WriteLine();

        // ==================== Задание 8 ====================
        // Сдвиг по ключевому слову (шифр Виженера)
        Console.WriteLine("=== Задание 8. Сдвиг по ключевому слову ===");
        Console.Write("Введите текст (русские буквы): ");
        string text8 = Console.ReadLine() ?? "";
        Console.Write("Введите ключ (слово, например КЛЮЧ): ");
        string keyWord8 = (Console.ReadLine() ?? "КЛЮЧ").ToUpper();
        string encrypted8 = "";
        int keyIdx8 = 0;
        foreach (char c in text8)
        {
            int shift8 = (keyWord8[keyIdx8 % keyWord8.Length] - 'А') + 1;
            if (c >= 'А' && c <= 'Я')
            {
                encrypted8 += (char)('А' + (c - 'А' + shift8) % 32);
                keyIdx8++;
            }
            else if (c >= 'а' && c <= 'я')
            {
                encrypted8 += (char)('а' + (c - 'а' + shift8) % 32);
                keyIdx8++;
            }
            else
            {
                encrypted8 += c;
            }
        }
        Console.WriteLine("Зашифровано: " + encrypted8);
        Console.WriteLine();

        // ==================== Задание 9 ====================
        // Вставка случайной буквы после каждой буквы исходного текста
        Console.WriteLine("=== Задание 9. Вставка случайной буквы ===");
        Console.Write("Введите текст: ");
        string text9 = Console.ReadLine() ?? "";
        Random rnd9 = new Random();
        string alphabet9 = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string encrypted9 = "";
        foreach (char c in text9)
        {
            encrypted9 += c;
            encrypted9 += alphabet9[rnd9.Next(alphabet9.Length)];
        }
        Console.WriteLine("Зашифровано: " + encrypted9);
        Console.WriteLine();

        // ==================== Задание 10 ====================
        // Собственный шифр: «Обратный порядок + динамический сдвиг кода символа»
        // 1) Шифрование, 2) Дешифрование, 3) Демонстрация на примере
        Console.WriteLine("=== Задание 10. Собственный шифр ===");
        Console.Write("Введите текст для собственного шифра: ");
        string text10 = Console.ReadLine() ?? "";
        Console.Write("Введите числовой ключ (например, 5): ");
        int key10 = int.Parse(Console.ReadLine() ?? "5");

        // 1. Шифрование
        char[] encChars10 = new char[text10.Length];
        for (int i = 0; i < text10.Length; i++)
        {
            encChars10[i] = (char)(text10[i] + key10 + (i + 1) * 3);
        }
        Array.Reverse(encChars10);
        string encrypted10 = new string(encChars10);

        // 2. Дешифрование
        char[] decChars10 = encrypted10.ToCharArray();
        Array.Reverse(decChars10);
        for (int i = 0; i < decChars10.Length; i++)
        {
            decChars10[i] = (char)(decChars10[i] - key10 - (i + 1) * 3);
        }
        string decrypted10 = new string(decChars10);

        // 3. Демонстрация
        Console.WriteLine("Открытый текст: " + text10);
        Console.WriteLine("Зашифровано:    " + encrypted10);
        Console.WriteLine("Расшифровано:   " + decrypted10);
    }
}
