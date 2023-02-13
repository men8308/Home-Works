// Задача №31. Задайте массив из 12 элементов, заполненный случайными чмслами из промежутка [-9;9]. 
// Найдите сумму отрицательных и положительных элементовмассива.

/*
Console.Clear();
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join("  ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (var el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"Positive Sum = {positiveSum}, Negative Sum = {negativeSum} ");

int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];

    for (int i = 1; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue += 1);
    }
    return res;
}
*/




// Задача №32. Напишите программу, которая заменяет положительные элементы массива на отрицательные, а отрицательные на положительные

Console.Clear();

/*
int [] Array = GetArray (4, -8, 8);
Console.WriteLine(String.Join("  ", Array));
int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];

    for (int i = 1; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue += 1);
    }
    return res;
}
for (int i = 0; i < Array.Length; i++)
{
    Array[i] *= (-1);
    Console.Write($" {Array[i]}");
}
*/






// Задача №33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

Console.Clear();

int [] SomeElements (int size, int minValue, int maxValue)
{
    int [] res = new int [size];

    for (int i = 1; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue += 1);
    }
    return res;
}

int[] Massiv = SomeElements (5, 0, 5);

System.Console.WriteLine("Enter else number ");

Console.WriteLine(String.Join(" ", Massiv));

int temp = int.Parse(Console.ReadLine());
bool Yes = false;
foreach (var i in Massiv)
{
    if (Math.Abs(i) == Math.Abs(temp))
    Yes = true;
}

if (Yes) System.Console.WriteLine("Да");
else
{
    System.Console.WriteLine("Нет");
}

