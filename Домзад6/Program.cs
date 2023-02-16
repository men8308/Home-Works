// https://learn.microsoft.com/en-us/dotnet/api/system.string.split?view=net-7.0

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");

// int EnterNumber (string number)
// {
//     Console.WriteLine($"Enter {number}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// int ArraySize = EnterNumber("array size");
// int minValue = EnterNumber("minvalue for array");
// int maxValue = EnterNumber("maxvallue for array");

// int [] numbers = CreateArray(ArraySize, minValue, maxValue);

// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
   
//     if (numbers [i] > 0)
//     {
//         count ++;
//     }
// }

// Console.Write($"Number of positive elements: {count}");













// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
 
 
// var x = -(b1 - b2) / (k1 - k2); //решаем систему уравнений, выражаем Х
// var y = k1 * x + b1; // У в системе уравнений остается
 
// x = Math.Round(x, 3); 
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");




