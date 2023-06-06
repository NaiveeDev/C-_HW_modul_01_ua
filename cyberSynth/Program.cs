using System;
using System.Data;
using System.Globalization;

//#1 TASK
/*class Program {
    static void Main() {
        Console.WriteLine("Введите число от 1 до 100:");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int number))
        {
            if (number >= 1 && number <= 100) {
                if (number % 3 == 0 && number % 5 == 0) {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(number);
                }
            }
            else {
                Console.WriteLine("Ошибка! Число должно быть в диапазоне от 1 до 100.");
            }
        }
        else {
            Console.WriteLine($"Ошибка! \"{userInput}\" некорректное значение.");
        }
    }
}*/

//#2 TASK
/*class Program2 {

    static void Main() {

        Console.WriteLine("Введите число:");
        string userInput1 = Console.ReadLine();
        Console.WriteLine("Введите процент:");
        string userInput2 = Console.ReadLine();

        if (decimal.TryParse(userInput1, out decimal number) && decimal.TryParse(userInput2, out decimal percent)) {
            decimal result = number * (percent / 100);
            Console.WriteLine($"Результат: {result}");
        }
        else {
            Console.WriteLine("Ошибка! Введено некорректное значение.");
        }

    }


}*/

//#3 TASK
/*class Program3 {

    static void Main() {

        Console.WriteLine("| Сложение чисел в одно |\n");

        int[] digits = new int[4];

        for (int i = 0; i < digits.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1}-ую цифру:");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int digit)) {
                digits[i] = digit;
            }
            else {
                Console.WriteLine($"Ошибка! Введенное значение \"{userInput}\" не является цифрой.");
                return; 
            }
        }

        int number = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];
        Console.WriteLine($"Исходное число: {number}");
       

    }

}*/

//#4 TASK
/*class Program4 {

    static void Main() {

        Console.WriteLine("Введите 6-тизначное число: ");
        string numberInput = Console.ReadLine();

        if (numberInput.Length != 6) {
            Console.WriteLine("Ошибка! Число не является 6-тизначным");
            return;
        }

        Console.WriteLine("Введите номера разрядов: ");
        int pos1 = int.Parse(Console.ReadLine());
        int pos2 = int.Parse(Console.ReadLine());

        if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
        {
            Console.WriteLine("Ошибка! Номера разрядов должны быть от 1 до 6.");
            return;
        }

        string result = swapNum(numberInput, pos1 - 1, pos2 - 1);
        Console.WriteLine("Результат: " + result);
    }

    static string swapNum(string number, int pos1, int pos2)
    {
        char[] digits = number.ToCharArray();
        char temp = digits[pos1];
        digits[pos1] = digits[pos2];
        digits[pos2] = temp;
        return new string(digits);
    }
}*/

//#5 TASK
/*class Program5     {

    static void Main() {

        Console.WriteLine("Введите дату в формате 01.01.1000:");
        string userInput = Console.ReadLine();

        if (DateTime.TryParseExact(userInput, "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime date)) {
            string season = getSeason(date);
            string day = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToString("dddd"));
            Console.WriteLine($"Пора года: {season}\nДень недели: {day}");
        }
        else
        {
            Console.WriteLine("Ошибка! Введена некорректная дата.");
        }

        
        static string getSeason(DateTime date)
        {
            int month = date.Month;

            if (month >= 3 && month <= 5)
                return "Весна";
            else if (month >= 6 && month <= 8)
                return "Лето";
            else if (month >= 9 && month <= 11)
                return "Осень";
            else
                return "Зима";
        }

    }

}*/

//#6TASK
/*class Program6 {

    static float FToC(float F, float C) {

        return F;
    }

    static void Main() {


        Console.WriteLine("| Конвертер градусов |");
        Console.WriteLine("1. Конвертировать из Фаренгейта в Цельсий");
        Console.WriteLine("2. Конвертировать из Цельсия в Фаренгейт");

        int choice = int.Parse(Console.ReadLine());

        decimal temperature;

        switch (choice)
        {
            case 1:
                Console.Write("Введите температуру в Фаренгейтах: ");
                temperature = decimal.Parse(Console.ReadLine());
                decimal cel = FaToCel(temperature);
                Console.WriteLine("Температура в Цельсиях: " + cel);
                break;

            case 2:
                Console.Write("Введите температуру в Цельсияъ ");
                temperature = decimal.Parse(Console.ReadLine());
                decimal fa = CelToFa(temperature);
                Console.WriteLine("Температура в Фаренгейтах: " + fa);
                break;

            default:
                Console.WriteLine("Ошибка! Введите верное значение.");
                break;
        }

        Console.ReadLine();
    }

    static decimal FaToCel(decimal fa) {
        return (fa - 32) * 5 / 9;
    }

    static decimal CelToFa(decimal cel) {
        return (cel * 9 / 5) + 32;
    }
}*/

//#7 TASK
/*class Program7 {

    static void Main()
    {

        Console.WriteLine("Введите диапозон: ");
        int userInput1 = int.Parse(Console.ReadLine());
        int userInput2 = int.Parse(Console.ReadLine());

        int start = Math.Min(userInput1, userInput2);
        int end = Math.Max(userInput1, userInput2);

        Console.WriteLine($"Парные числа в диапозоне от {start} до {end}: ");

        for (int i = start; i <= end; i++) {
            if (i % 2 == 0) {
                Console.WriteLine(i);
            }
        }
    }

}*/