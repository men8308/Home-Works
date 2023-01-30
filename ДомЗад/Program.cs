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
// if (B >= A)
// {Console.WriteLine("max=NumB");}
// else if (B >= C)
// {Console.WriteLine("max =  NumB");}
// else if (C >= A)
// {Console.WriteLine("max =  NumC");}
// else if (C >= B)
// {Console.WriteLine("max =  NumC");}
// else
// {Console.WriteLine("max =  NumA");}





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





// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter number");
string strNumb = Console.ReadLine();
int Numb = Convert.ToInt32(strNumb);

int i = 0;
if (i <= Numb)
{
    i += 2;
    Console.WriteLine(i);
}
else {;}