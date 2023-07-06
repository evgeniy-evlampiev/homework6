// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введите числа через пробел: ");
// int[] numbers = GetArrayFromString(Console.ReadLine()!);

// int[] GetArrayFromString(string stringArray)
// {
//     string[] numS = stringArray.Split(' ',StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[numS.Length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i]= int.Parse(numS[i]);
//     }
//     return result;
// }

// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Количество элементов больше 0 равно {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());


// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// x = Math.Round(x, 3);
// y = Math.Round(y, 3);

// Console.WriteLine($"Пересечение в точке: ({x};{y})");