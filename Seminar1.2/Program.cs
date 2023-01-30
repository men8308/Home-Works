// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли превое число квадратом второго

// а = 25, b = 5, => да
// а = 2, b = 10, => нет
// а = 9, b = -3, => да
// а = -3, b = 9, => нет

Console.WriteLine("Enter number a :");

string strNumberA = Console.ReadLine();

int numberA=Convert.ToInt32(strNumberA);

Console.WriteLine("Enter number b :");

string strNumberB = Console.ReadLine();

int numberB=Convert.ToInt32(strNumberB);

if (numberA / numberB == numberB)
{
    Console.WriteLine ("Первое число является квадрвтом второго");
}
else
{
    Console.WriteLine ("Первое число не является квадрвтом второго");
}