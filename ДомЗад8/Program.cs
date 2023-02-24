Console.Clear();

// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
MinishingRow(array);
Console.WriteLine();
PrintArray(array);


void FillArray(int[,] array) //Метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array) //Метод вывода на печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinishingRow(int[,] array) //Метод упорядочивания по убыванию элементов каждой строки
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
*/







// Задача №56. Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
MinimumSumRow(array);

void FillArray(int[,] array) //Метод заполнения массива числами от 1 до 9
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array) //Метод вывода на печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinimumSumRow(int[,] array) //Метод нахождения строки с минимальной суммой элементов
{
    int MinSumRow = 0; //Строка с минимальной суммой элементов
    int MinSum = 0; //Сумма элементов в строке
    int Count = 0; //Счетчик индекса строки

    for (int i = 0; i < array.GetLength(1); i++) //Условно определяем строку с мин. суммой элементов
    {
        MinSumRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++) //Шагаем по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++) //Шагаем по элементоам i-ой строки 
        MinSum += array[i, j]; //и суммируем элементы i-ой строки
        //System.Console.WriteLine(MinSum);           
        if (MinSum < MinSumRow) //Сравниваем условную минимальную строку с посчитанной выше строкой
        {
            MinSumRow = MinSum; // Если сумма эл-в в текущей строке меньше, то записываем её как минимальную строку
            Count = i; //записываем номер строки в счетчик
        }  
        MinSum = 0;
    }

    Console.WriteLine($"{Count + 1} строка");
}
*/








// Задача №58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] array3 = new int[2, 2];

FillArray(array1);
PrintArray(array1);
Console.WriteLine();

FillArray(array2);
PrintArray(array2);
Console.WriteLine();

FillArray(array3);
MatrixMult(array1, array2, array3);
PrintArray(array3);

void MatrixMult(int[,] array1, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int temp = 0;
            for (int m = 0; m < array2.GetLength(0); m++)
            {
                temp += array1[i, m] * array2[m, j];
            }
            array3[i, j] = temp;
            // System.Console.WriteLine(array3);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
*/









// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintArray(array3D);



void PrintArray(int[,,] array3D)
{
    for (int h = 0; h < array3D.GetLength(0); h++)
    {
        for (int l = 0; l < array3D.GetLength(1); l++)
        {
            for (int d = 0; d < array3D.GetLength(2); d++)
            {
                Console.Write($"{array3D[h, l, d]} ({h}, {l}, {d})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] array3D)
{
    int temp = 10;
    for (int h = 0; h < array3D.GetLength(0); h++)
    {
        for (int l = 0; l < array3D.GetLength(1); l++)
        {
            for (int d = 0; d < array3D.GetLength(2); d++)
            {
                // array3D[h, l, d] = new Random().Next(10, 20);
                // int temp = 1;                   //Надо допилить
                array3D[h, l, d] += temp;       //этот код
                temp += 2;                        //исключения повторяемости

            }
        }
    }
}