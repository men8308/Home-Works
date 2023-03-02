// Задача №64: Задайте значение N. 
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


/*
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
*/












// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


Console.Write("Enter positive number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter positive number N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write($"Function Akkerman = {Akkerman(m, n)}"); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}