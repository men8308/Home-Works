// Задача №34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear(); //Чистим окно терминала

/*
Console.Write("Enter the size of the array : "); //Просим пользователя ввести размер массива

int size = Convert.ToInt32(Console.ReadLine()); //Преобразовывем из строки в натуральное число

int[] numbers = new int[size]; //Создаем наш маив
Array(numbers); // Заполняем наш массив
Console.Write("This is our array : "); //Выводим в консоль наш заполненный массив 
PrintArray(numbers);//Выводим в консоль наш заполненный массив

// Считаем количество чётных чисел
int count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.Write($"In our array {count} even numbers from {numbers.Length} available");

// Метод заполнения массива
void Array(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

Метод вычисления чётных чисел

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/





// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


Console.Write("Enter the size of the array : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Array(numbers);
Console.Write("This is our array : ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

    Console.WriteLine($"Sum of elements in odd positions = {sum}");

void Array(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}