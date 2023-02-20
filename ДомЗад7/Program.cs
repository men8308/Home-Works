// Задача 47.Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


Console.Clear();

// int rows = ReadInt("Enter Rows: ");
// int colums = ReadInt("Enter Columns: ");
// double[,] numbers = new double[rows, colums];
// FillArray2D(numbers);
// PrintArray2D(numbers);
// // Заполнение массива рандомными вещественными числами
// void FillArray2D(double[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = new Random().Next(-99, 100) / 10.0;
// }
// }
// }
// // Функция вывода массива в терминал
// void PrintArray2D(double[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i, j] + " ");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }
// // Функция ввода
// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Во вводе первая цифра - номер строки, вторая - столбца.


// int rows = ReadInt("Enter Rows's index: ");
// int colums = ReadInt("Enter Columns's endex: ");
// int[,] numbers = new int[9, 9];
// FillArray2D(numbers);
// PrintArray2D(numbers);
// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows},{colums} -> there is no such number in the array");
// // Заполнение массива рандомными числами от 1 до 9
// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// // Функция вывода массива в терминал
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }





// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// int rows = ReadInt("Enter Rows: ");
// int colums = ReadInt("Enter Columns: ");
// int[,] numbers = new int[rows, colums];

// FillArray2D(numbers);
// PrintArray2D(numbers);
// ReadInt(numbers);

// // Заполнение массива рандомными числами от 1 до 9
// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // Функция вывода массива в терминал
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



int rows = 3;
int colums = 4;
int[,] numbers = new int[rows, colums];

FillArray2D(numbers);
PrintArray2D(numbers);

double[] avgNumbers = new double[numbers.GetLength(1)];
for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result1 = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result1 += numbers[j, i];
    }
    avgNumbers[i] = Math.Round(result1 / numbers.GetLength(0), 2);
}
PrintArray(avgNumbers);
// Заполнение массива рандомными вещественными числами
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
// Функция вывода двумерного массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Функция вывода массива в терминал
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}







