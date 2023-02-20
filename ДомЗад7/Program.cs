// Задача 47.Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int rows = ReadInt("Enter Rows: ");
int colums = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);
// Заполнение массива рандомными вещественными числами
void FillArray2D(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(-99, 99) / 10.0;
}
}
}
// Функция вывода массива в терминал
void PrintArray2D(double[,] array)
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
// Функция ввода
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}





