using System;

class Program
{
    static void Main()
    {
        // Задание 1. Анализ энтропии пароля (длина потока до переноса строки или точки)
        Console.Write("Задание 1. Введите пароль (до точки или Enter): ");
        string pass1 = Console.ReadLine();
        int i1 = 0;
        int len1 = 0;
        while (i1 < pass1.Length && pass1[i1] != '.' && pass1[i1] != '
')
        {
            len1++;
            i1++;
        }
        Console.WriteLine("Длина пароля: " + len1);
        if (len1 < 8)
        {
            Console.WriteLine("Предупреждение: длина пароля меньше 8 символов!");
        }

        // Задание 2. Ограничение попыток входа (Защита от Brute Force)
        string rightPass = "SecurePass123";
        int tries = 0;
        bool isLogin = false;
        while (tries < 3 && !isLogin)
        {
            Console.Write("Задание 2. Введите пароль: ");
            string inputPass = Console.ReadLine();
            tries++;
            if (inputPass == rightPass)
            {
                isLogin = true;
                Console.WriteLine("Вход выполнен успешно!");
            }
            else
            {
                Console.WriteLine("Неверный пароль.");
            }
        }
        if (!isLogin)
        {
            Console.WriteLine("Учетная запись заблокирована.");
        }

        // Задание 3. Поиск утечки памяти в лог-файле
        Console.Write("Задание 3. Введите объем памяти в Мб (0 - конец): ");
        int prevMem = int.Parse(Console.ReadLine());
        int growCount = 0;
        while (prevMem != 0)
        {
            Console.Write("Введите объем памяти в Мб (0 - конец): ");
            int curMem = int.Parse(Console.ReadLine());
            if (curMem == 0) break;
            if (curMem > prevMem)
            {
                growCount++;
            }
            prevMem = curMem;
        }
        Console.WriteLine("Память увеличивалась подряд: " + growCount + " раз");

        // Задание 4. Вычисление контрольной суммы (сумма цифр числа)
        Console.Write("Задание 4. Введите целое число (ID сессии): ");
        int num4 = int.Parse(Console.ReadLine());
        int sum4 = 0;
        while (num4 > 0)
        {
            sum4 += num4 % 10;
            num4 /= 10;
        }
        Console.WriteLine("Сумма цифр числа: " + sum4);

        // Задание 5. Генерация одноразовых паролей (OTP) до совпадения условий
        Random rnd5 = new Random();
        int otp = 0;
        int count5 = 0;
        while (otp == 0 || otp % 7 != 0 || otp % 2 == 0)
        {
            otp = rnd5.Next(100000, 1000000);
            count5++;
        }
        Console.WriteLine("Задание 5. Сгенерированный OTP: " + otp);
        Console.WriteLine("Количество генераций: " + count5);

        // Задание 6. Дешифратор методом сдвига (Цезарь наоборот)
        int key6 = 3;
        string result6 = "";
        Console.Write("Задание 6. Введите код символа (отрицательное число - стоп): ");
        int code6 = int.Parse(Console.ReadLine());
        while (code6 >= 0)
        {
            result6 += (char)(code6 - key6);
            Console.Write("Введите код символа (отрицательное число - стоп): ");
            code6 = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Расшифрованный текст: " + result6);

        // Задание 7. Мониторинг сетевого трафика (Превышение лимита 5000 байт)
        int traffic = 0;
        while (traffic <= 5000)
        {
            Console.Write("Задание 7. Введите размер пакета в байтах: ");
            int packet = int.Parse(Console.ReadLine());
            traffic += packet;
        }
        Console.WriteLine("Превышен лимит 5000 байт! Подозрение на DDoS-атаку.");

        // Задание 8. Анализ стойкости шифротекста (Поиск повторяющихся знаков)
        Console.Write("Задание 8. Введите текст сообщения: ");
        string text8 = Console.ReadLine();
        int i8 = 1;
        int repeats = 0;
        while (i8 < text8.Length)
        {
            if (text8[i8] == text8[i8 - 1])
            {
                repeats++;
            }
            i8++;
        }
        Console.WriteLine("Повторяющихся подряд символов: " + repeats);

        // Задание 9. Дифференциация прав доступа (Сканирование портов)
        Console.Write("Задание 9. Введите стартовый номер порта: ");
        int port = int.Parse(Console.ReadLine());
        int checkedPorts = 0;
        while (port % 13 != 0 && checkedPorts < 50)
        {
            port++;
            checkedPorts++;
        }
        if (port % 13 == 0)
        {
            Console.WriteLine("Открытый порт найден: " + port);
        }
        else
        {
            Console.WriteLine("Проверено 50 портов, открытых нет.");
        }

        // Задание 10. Очистка буфера обмена (Затирание данных)
        Console.Write("Задание 10. Введите размер буфера в байтах: ");
        int bytes = int.Parse(Console.ReadLine());
        while (bytes > 0)
        {
            Console.WriteLine("Байт " + bytes + ": 0x00");
            bytes--;
        }
        Console.WriteLine("Память очищена.");

        // Задание 11. Поиск «магических байт» (Валидация заголовка файла 77, 90)
        int pos11 = 0;
        bool isExe = true;
        while (pos11 < 4)
        {
            Console.Write("Задание 11. Введите байт (0-255): ");
            int b = int.Parse(Console.ReadLine());
            if ((pos11 == 0 && b != 77) || (pos11 == 1 && b != 90))
            {
                Console.WriteLine("Обнаружена подмена файла! Заголовок не совпадает.");
                isExe = false;
                break;
            }
            pos11++;
        }
        if (isExe)
        {
            Console.WriteLine("Заголовок файла корректен (0x4D, 0x5A).");
        }

        // Задание 12. Поиск скрытого сообщения (Стеганография)
        Console.Write("Задание 12. Введите исходный текст: ");
        string text12 = Console.ReadLine();
        string secret12 = "";
        int i12 = 0;
        while (i12 < text12.Length && secret12.Length < 5)
        {
            if (char.IsUpper(text12[i12]))
            {
                secret12 += text12[i12];
            }
            i12++;
        }
        Console.WriteLine("Секретное сообщение: " + secret12);

        // Задание 13. Имитация атаки Time-Based Blind SQL Injection
        Console.Write("Задание 13. Введите секретный символ (a-z): ");
        char secretChar = Console.ReadLine()[0];
        char curChar = 'a';
        while (curChar <= 'z')
        {
            if (curChar == secretChar)
            {
                Console.WriteLine("Символ найден: " + curChar);
                break;
            }
            int pause = 0;
            while (pause < 100000)
            {
                pause++;
            }
            curChar++;
        }

        // Задание 14. Сборка фрагментированных пакетов (Reassembly)
        int expected = 1;
        while (expected <= 4)
        {
            Console.Write("Задание 14. Введите номер пакета (ожидается " + expected + "): ");
            int num = int.Parse(Console.ReadLine());
            if (num != expected)
            {
                Console.WriteLine("Ошибка целостности доставки! Сборка завершена.");
                break;
            }
            expected++;
        }

        // Задание 15. Мониторинг «песочницы» (Защита от Anti-Debugging)
        long startTicks = DateTime.Now.Ticks;
        int counter15 = 0;
        while (counter15 < 1000000)
        {
            counter15++;
        }
        long endTicks = DateTime.Now.Ticks;
        long elapsedMs = (endTicks - startTicks) / 10000;
        Console.WriteLine("Задание 15. Время выполнения (мс): " + elapsedMs);
        if (elapsedMs > 100)
        {
            Console.WriteLine("Обнаружена отладка! Экстренное завершение работы.");
        }
        else
        {
            Console.WriteLine("Программа работает в обычном режиме.");
        }
    }
}
