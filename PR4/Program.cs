using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ==================== Пример выполнения задания ====================
        // Подбор 4-значного цифрового PIN-кода методом перебора (Brute Force)
        Console.WriteLine("=== Пример. Подбор 4-значного PIN-кода (Brute Force) ===");
        Console.Write("Введите эталонный 4-значный PIN-код (например, 4821): ");
        int targetPin = int.Parse(Console.ReadLine() ?? "4821");
        int currentTry = 0;
        int pinAttempts = 0;
        while (currentTry != targetPin && currentTry <= 9999)
        {
            pinAttempts++;
            currentTry++;
        }
        if (currentTry == targetPin)
        {
            Console.WriteLine("[УСПЕХ] PIN-код взломан!");
            Console.WriteLine($"Подобранный код: {currentTry:D4}");
            Console.WriteLine($"Количество попыток: {pinAttempts}");
        }
        Console.WriteLine();

        // ==================== Задание 1 ====================
        // Анализ энтропии пароля (длина потока до 
 или точки)
        Console.WriteLine("=== Задание 1. Анализ энтропии пароля ===");
        Console.Write("Введите пароль (чтение до Enter или точки '.'): ");
        int passLength1 = 0;
        int ch1 = Console.Read();
        while (ch1 != -1 && (char)ch1 != '
' && (char)ch1 != '' && (char)ch1 != '.')
        {
            passLength1++;
            ch1 = Console.Read();
        }
        if (ch1 == '.' || ch1 == '')
        {
            Console.ReadLine(); // очистка остатка строки в буфере
        }
        Console.WriteLine($"Длина пароля: {passLength1}");
        if (passLength1 < 8)
            Console.WriteLine("[ПРЕДУПРЕЖДЕНИЕ] Пароль слишком короткий (менее 8 символов)!");
        else
            Console.WriteLine("[ОК] Длина пароля достаточна.");
        Console.WriteLine();

        // ==================== Задание 2 ====================
        // Ограничение попыток входа (Защита от Brute Force, не более 3 попыток)
        Console.WriteLine("=== Задание 2. Ограничение попыток входа ===");
        string correctPass2 = "SecurePass123";
        int attempts2 = 0;
        bool accessGranted2 = false;
        while (attempts2 < 3 && !accessGranted2)
        {
            Console.Write($"Введите пароль (попытка {attempts2 + 1} из 3): ");
            string inputPass2 = Console.ReadLine() ?? "";
            attempts2++;
            if (inputPass2 == correctPass2)
                accessGranted2 = true;
            else
                Console.WriteLine($"Неверный пароль! Осталось попыток: {3 - attempts2}");
        }
        if (accessGranted2)
            Console.WriteLine("[ДОСТУП РАЗРЕШЁН]");
        else
            Console.WriteLine("[БЛОКИРОВКА] Учётная запись заблокирована!");
        Console.WriteLine();

        // ==================== Задание 3 ====================
        // Поиск утечки памяти в лог-файле (ввод до 0)
        Console.WriteLine("=== Задание 3. Поиск утечки памяти в лог-файле ===");
        Console.Write("Введите начальный объём памяти в Мб (0 — выход): ");
        int prevMem3 = int.Parse(Console.ReadLine() ?? "0");
        int streak3 = 0;
        int maxStreak3 = 0;
        while (prevMem3 != 0)
        {
            Console.Write("Введите следующий объём памяти в Мб (0 — выход): ");
            int currMem3 = int.Parse(Console.ReadLine() ?? "0");
            if (currMem3 == 0) break;
            if (currMem3 > prevMem3)
            {
                streak3++;
                if (streak3 > maxStreak3) maxStreak3 = streak3;
            }
            else
            {
                streak3 = 0;
            }
            prevMem3 = currMem3;
        }
        Console.WriteLine($"Память увеличивалась подряд максимум: {maxStreak3} раз(а).");
        Console.WriteLine();

        // ==================== Задание 4 ====================
        // Вычисление контрольной суммы цифр числа (Хеширование подмешиванием)
        Console.WriteLine("=== Задание 4. Вычисление контрольной суммы ===");
        Console.Write("Введите целое число (ID сессии): ");
        long sessionId4 = Math.Abs(long.Parse(Console.ReadLine() ?? "0"));
        long sumDigits4 = 0;
        while (sessionId4 > 0)
        {
            sumDigits4 += sessionId4 % 10;
            sessionId4 /= 10;
        }
        Console.WriteLine($"Контрольная сумма цифр: {sumDigits4}");
        Console.WriteLine();

        // ==================== Задание 5 ====================
        // Генерация одноразовых паролей (OTP) от 100000 до 999999 (делится на 7 и нечётный)
        Console.WriteLine("=== Задание 5. Генерация одноразовых паролей (OTP) ===");
        Random rnd5 = new Random(2026);
        int otp5 = 0;
        int genCount5 = 0;
        while (otp5 == 0 || otp5 % 7 != 0 || otp5 % 2 == 0)
        {
            otp5 = rnd5.Next(100000, 1000000);
            genCount5++;
        }
        Console.WriteLine($"Полученный сильный OTP-код: {otp5}");
        Console.WriteLine($"Количество генераций: {genCount5}");
        Console.WriteLine();

        // ==================== Задание 6 ====================
        // Дешифратор методом сдвига (Цезарь наоборот, ввод кодов до отрицательного числа)
        Console.WriteLine("=== Задание 6. Дешифратор методом сдвига ===");
        Console.Write("Введите ключ сдвига (например, 3): ");
        int key6 = int.Parse(Console.ReadLine() ?? "3");
        string decodedText6 = "";
        while (true)
        {
            Console.Write("Введите код символа (отрицательное число — конец): ");
            int code6 = int.Parse(Console.ReadLine() ?? "-1");
            if (code6 < 0) break;
            decodedText6 += (char)(code6 - key6);
        }
        Console.WriteLine("Расшифрованная строка: " + decodedText6);
        Console.WriteLine();

        // ==================== Задание 7 ====================
        // Мониторинг сетевого трафика (Превышение лимита 5000 байт)
        Console.WriteLine("=== Задание 7. Мониторинг сетевого трафика ===");
        int totalTraffic7 = 0;
        while (totalTraffic7 <= 5000)
        {
            Console.Write("Введите размер пакета в байтах: ");
            int packetSize7 = int.Parse(Console.ReadLine() ?? "0");
            totalTraffic7 += packetSize7;
            Console.WriteLine($"Текущий трафик: {totalTraffic7} / 5000 байт");
        }
        Console.WriteLine("[ТРЕВОГА] Превышен лимит 5000 байт! Подозрение на DDoS-атаку.");
        Console.WriteLine();

        // ==================== Задание 8 ====================
        // Анализ стойкости шифротекста (Поиск повторяющихся подряд знаков)
        Console.WriteLine("=== Задание 8. Анализ стойкости шифротекста ===");
        Console.Write("Введите текст сообщения: ");
        string text8 = Console.ReadLine() ?? "";
        int idx8 = 1;
        int repeats8 = 0;
        while (idx8 < text8.Length)
        {
            if (text8[idx8] == text8[idx8 - 1])
                repeats8++;
            idx8++;
        }
        Console.WriteLine($"Одинаковые символы подряд встречаются: {repeats8} раз(а).");
        Console.WriteLine();

        // ==================== Задание 9 ====================
        // Дифференциация прав доступа (Сканирование портов: кратный 13 или 50 портов)
        Console.WriteLine("=== Задание 9. Сканирование портов ===");
        Console.Write("Введите стартовый номер порта (например, 79): ");
        int port9 = int.Parse(Console.ReadLine() ?? "79");
        int checkedPorts9 = 0;
        while (checkedPorts9 < 50)
        {
            checkedPorts9++;
            if (port9 % 13 == 0)
            {
                Console.WriteLine($"Найден открытый порт: {port9} (проверено портов: {checkedPorts9})");
                break;
            }
            port9++;
        }
        if (port9 % 13 != 0)
            Console.WriteLine("Открытых портов за 50 шагов не обнаружено.");
        Console.WriteLine();

        // ==================== Задание 10 ====================
        // Очистка буфера обмена (Затирание данных до 0)
        Console.WriteLine("=== Задание 10. Очистка буфера обмена ===");
        Console.Write("Введите размер буфера в байтах: ");
        int bufferBytes10 = int.Parse(Console.ReadLine() ?? "0");
        while (bufferBytes10 > 0)
        {
            Console.WriteLine($"Байт #{bufferBytes10} перезаписан: 0x00");
            bufferBytes10--;
        }
        Console.WriteLine("Буфер полностью затёрт (0 байт).");
        Console.WriteLine();

        // ==================== Задание 11 ====================
        // Поиск «магических байт» (Валидация заголовка MZ: 77, 90)
        Console.WriteLine("=== Задание 11. Поиск магических байт заголовка ===");
        int[] mzSignature11 = { 77, 90, 144, 0 };
        int bytePos11 = 0;
        bool validHeader11 = true;
        while (bytePos11 < 4)
        {
            Console.Write($"Введите байт #{bytePos11} (0..255): ");
            int b11 = int.Parse(Console.ReadLine() ?? "0");
            if ((bytePos11 == 0 && b11 != mzSignature11[0]) || (bytePos11 == 1 && b11 != mzSignature11[1]))
            {
                Console.WriteLine("[ОШИБКА] Заголовок не соответствует сигнатуре MZ (0x4D, 0x5A)! Обнаружена подмена файла.");
                validHeader11 = false;
                break;
            }
            bytePos11++;
        }
        if (validHeader11)
            Console.WriteLine("[ОК] Сигнатура заголовка файла подтверждена.");
        Console.WriteLine();

        // ==================== Задание 12 ====================
        // Поиск скрытого сообщения (Стеганография: 5 заглавных букв)
        Console.WriteLine("=== Задание 12. Стеганография ===");
        Console.Write("Введите исходный текст: ");
        string stegoText12 = Console.ReadLine() ?? "";
        string secret12 = "";
        int pos12 = 0;
        while (pos12 < stegoText12.Length && secret12.Length < 5)
        {
            if (char.IsUpper(stegoText12[pos12]))
                secret12 += stegoText12[pos12];
            pos12++;
        }
        Console.WriteLine("Секретное сообщение: " + secret12);
        Console.WriteLine();

        // ==================== Задание 13 ====================
        // Имитация атаки Time-Based Blind SQL Injection (перебор 'a'..'z')
        Console.WriteLine("=== Задание 13. Имитация Time-Based Blind SQL Injection ===");
        Console.Write("Введите предполагаемый секретный символ ('a'..'z'): ");
        string input13 = Console.ReadLine() ?? "d";
        char targetChar13 = input13.Length > 0 ? input13[0] : 'd';
        char currentChar13 = 'a';
        while (currentChar13 <= 'z')
        {
            if (currentChar13 == targetChar13)
            {
                Console.WriteLine($"[УСПЕХ] Символ '{currentChar13}' подобран!");
                break;
            }
            else
            {
                int pause13 = 0;
                while (pause13 < 100000) pause13++; // эмуляция сетевой задержки
                Console.WriteLine($"Символ '{currentChar13}' не подошёл (задержка {pause13} итераций)");
            }
            currentChar13++;
        }
        Console.WriteLine();

        // ==================== Задание 14 ====================
        // Сборка фрагментированных пакетов (контроль последовательности 1, 2, 3...)
        Console.WriteLine("=== Задание 14. Сборка фрагментированных пакетов ===");
        Console.Write("Введите количество ожидаемых пакетов: ");
        int totalPackets14 = int.Parse(Console.ReadLine() ?? "4");
        int expectedPacket14 = 1;
        while (expectedPacket14 <= totalPackets14)
        {
            Console.Write($"Введите номер пакета (ожидается {expectedPacket14}): ");
            int received14 = int.Parse(Console.ReadLine() ?? "0");
            if (received14 != expectedPacket14)
            {
                Console.WriteLine($"[ОШИБКА ЦЕЛОСТНОСТИ] Нарушена последовательность! Ожидался пакет #{expectedPacket14}, получен #{received14}.");
                break;
            }
            Console.WriteLine($"Пакет #{received14} принят.");
            expectedPacket14++;
        }
        Console.WriteLine();

        // ==================== Задание 15 ====================
        // Мониторинг «песочницы» (Защита от Anti-Debugging: 1 000 000 операций)
        Console.WriteLine("=== Задание 15. Мониторинг песочницы (Anti-Debugging) ===");
        Console.Write("Введите лимит времени в мс (например, 100): ");
        long limitMs15 = long.Parse(Console.ReadLine() ?? "100");
        int opsCounter15 = 0;
        Stopwatch sw15 = Stopwatch.StartNew();
        while (opsCounter15 < 1000000)
        {
            opsCounter15++;
        }
        sw15.Stop();
        Console.WriteLine($"Выполнено {opsCounter15} итераций за {sw15.ElapsedMilliseconds} мс.");
        if (sw15.ElapsedMilliseconds > limitMs15)
            Console.WriteLine("[ТРЕВОГА] Подозрительно долгое выполнение! Обнаружена отладка ИБ — экстренное завершение.");
        else
            Console.WriteLine("[ОК] Время выполнения в норме.");
    }
}
