// Задача №64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


Console.Clear();


Console.Write("Enter positive number : ");
int number = int.Parse(Console.ReadLine());

//Рекурсивный метод вывода всех натуральных чисел от number до 1:
void NumberCounterReverse (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write(number );
    NumberCounterReverse (number - 1);
}

NumberCounterReverse(number);
