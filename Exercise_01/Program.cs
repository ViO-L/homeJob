// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Первый способ решения задачи:

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number >= 100) && (number < 1000))
// {
//     int secondNumber = number / 10 % 10;
//     Console.WriteLine($"Введенное число `{number}`");
//     Console.WriteLine($"Вторая цифра этого число `{secondNumber}`");

// }
// else
// {
//     Console.WriteLine("Вы ввели не трехзначное числ");
// }

// Второй способ решения задачи применяя метод Prompt:

// int Prompt(string msg)
// {
//     System.Console.WriteLine($"{msg}");
//     return Convert.ToInt32(Console.ReadLine());
// }
// int number = Prompt("Введите трехзначное число");
// if (number >= 100 && number < 1000)
// {
//     int secondNumber = number / 10 % 10;
//     System.Console.WriteLine($"Вторая цифра числа {number} является {secondNumber}");
// }
// else
// {
//     System.Console.WriteLine("Это число не трехзначное");
// }


// Пример идеального решения:
// int Prompt(string msg)
// {
//     System.Console.Write(msg);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int number = Prompt("Введите трехзначное число : ");
// if (number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число, повторите ввод");
//     return;
// }
// Console.WriteLine($"Введенное число `{number}`");
// int secondNumber = number / 10 % 10;
// Console.WriteLine($"Вторая цифра `{secondNumber}`");