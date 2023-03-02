﻿// Задача №64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


Console.Clear();

/*
Console.Write("Enter positive number : ");
int number = int.Parse(Console.ReadLine());

//Рекурсивный метод вывода всех натуральных чисел от number до 1:
void NumberCounterReverse(int number)
{
    if (number < 1 || number == 0) return;
    Console.Write(number);
    NumberCounterReverse(number - 1);
}

NumberCounterReverse(number);
*/















// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int m = InputNumbers("Enter natural number m: ");
int n = InputNumbers("Enter natural number n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

NumberCounterSumReverse(m, n, temp=0);

void NumberCounterSumReverse(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"our sum is from M to N = {summ}");
    return;
  }
  NumberCounterSumReverse(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

