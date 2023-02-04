// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Enter numA :");
// string strNumA = Console.ReadLine();
// int numA = Convert.ToInt32(strNumA);
// Console.WriteLine("Enter numB :");
// string strNumB = Console.ReadLine();
// int numB = Convert.ToInt32(strNumB);
// if (numA >= numB)
// {
//     Console.WriteLine("max = numA");
//     }
// else 
// {
//     Console.WriteLine("max =  numB");
// }




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Enter numA :");
// string strA = Console.ReadLine();
// int A = Convert.ToInt32(strA);
// Console.Write("Enter numB :");
// string strB = Console.ReadLine();
// int B = Convert.ToInt32(strB);
// Console.Write("Enter numC :");
// string strC = Console.ReadLine();
// int C = Convert.ToInt32(strC);
// int max = A;
// if (B >= max)
// {max = B;}
// if (C >= max)
// {max = C;}
// {Console.WriteLine($"max number =  {max}");}





// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Enter number :");
// string strA = Console.ReadLine();
// int evenNumber = Convert.ToInt32(strA);

// if (evenNumber%2 == 0)
// {
//     Console. Write("The number is even");
// }
// else 
// {
//     Console. Write("The number is not even");
// }





// задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Enter number");
// string strNumb = Console.ReadLine();
// int Numb = Convert.ToInt32(strNumb);

// int i = 0;
// while (i<=Numb)
// {if (i <= Numb)
// {
  
//     Console.WriteLine($"{i}");
// }
//   i += 2;
// }



// Задача 10: напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// System.Console.Clear();
// int number = new Random() .Next(99, 1000);//568
// int number1 = ((number%100)/10);
// System.Console.WriteLine($"Number = {number}");
// System.Console.WriteLine($"{number1}");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// System.Console.Clear();//Чистим экран терминала
// System.Console.Write("Enter any number ");//вводим любое число
// string strnumber1 = Console.ReadLine();//вводим переменную strnumber1 и считываем в неё введеные значения как строку
// int number1 = Convert.ToInt32(strnumber1);//вводим переменную number1 и конвертируем в неё цифру из strnumber1
// int result;//вводим переменную result
// if (number1 < 100)//условие для двухзначных чисел
// {    System.Console.WriteLine("No third digit");}
// else if ((number1 <= 999) && (number1 >= 100))//условие для 3-хзначных чисел
// {result = (number1%10);
//     System.Console.WriteLine($"Third digit = {result}");}
// else if ((number1<= 10000) && (number1 >= 1000))//условие для 4-хзначных чисел
// {    result = number1%100/10;
//    System.Console.WriteLine($"Third digit = {result}");}
// else if ((number1<= 100000) && (number1 >= 10000))//условие для 5-тизначных чисел
// {    result = number1%1000/100;
//    System.Console.WriteLine($"Third digit = {result}");}
// else if ((number1<= 1000000) && (number1 >= 100000))//условие для 6-тизначных чисел
// {    result = number1%10000/1000;
//    System.Console.WriteLine($"Third digit = {result}");}
//    else if ((number1<= 10000000) && (number1 >= 1000000))//условие для 7-мизначных чисел
// {    result = number1%100000/10000;
//    System.Console.WriteLine($"Third digit = {result}");}



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
System.Console.Clear();//Чистим экран терминала
System.Console.Write("enter a number from 1 to 7 ");//вводим число от 1 до 7
string strnumber = Console.ReadLine();//вводим переменную strnumber1 и считываем в неё введеные значения как строку
int number = Convert.ToInt32(strnumber);//вводим переменную number1 и конвертируем в неё цифру из strnumber1
int result;//вводим переменную result
if (number == 1)
{
    System.Console.Write("It's a Monday, a working day");
}
else if (number == 2)
{
    System.Console.Write("It's a Tuesday, a working day");
}
else if (number == 3)
{
    System.Console.Write("It's a Wednesday, a working day");
}
else if (number == 4)
{
    System.Console.Write("It's a Thursday, a working day");
}
else if (number == 5)
{
    System.Console.Write("It's a Friday, a working day");
}
else if (number == 6)
{
    System.Console.Write("It's a Saturday, a weekend");
}
else
{
    System.Console.Write("It's a Sanday, a weekend");
}