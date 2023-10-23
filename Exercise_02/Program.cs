// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Способ решения 1:

// Console.Write("Введите число: ");
// string  stringNumber = Console.ReadLine();
// int number;
// bool isNumber = int.TryParse(stringNumber, out number);
// if(isNumber && stringNumber.Length >= 3)
// {
//     Console.WriteLine($"{stringNumber} => {stringNumber[2]}");
// }
// else
// {
//     Console.WriteLine($"{stringNumber} -> Третьей цифры нет");
// }

// Способ решения 2:

// int ThirdDigit(int number)
// {
//             int result = -1;
//             if (number >= 100)
//             {
//                 while (number > 999)
//                 {
//                     number = number / 10;
//                 }
//                 result = number  % 10;
//             }
//             return result; 
//         }
// Console.Write("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
 
// if (ThirdDigit(number1) == -1)
// Console.WriteLine($"{number1} -> третьей цифры нет");
// else
// Console.WriteLine($"{number1} -> {ThirdDigit(number1)}");