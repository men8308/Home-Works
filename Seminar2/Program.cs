// Напишите программу, которая выводит случайное число из отрезка [10; 99] и показывает наибольшую цифру числа.
// int number = new Random() .Next(10, 100);

// int number1 = number/10;
// int number2 = number%10;

// Console.WriteLine($"number = {number}");
// if (number1 > number2)
// {
//     Console.WriteLine($"number1 = {number1} больше number2 = {number2}");
// }
// else if (number2 >number1)
// {
// Console.WriteLine($"number2 = {number2} больше number1 = {number1}");
// }
// else 
// {
//     Console.WriteLine($"number1 = {number1} равно number2 = {number2}");
// }



//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// System.Console.Clear();
// int number = new Random() .Next(100 ,1000);

// int number1 = number/100;
// int number3 = number%10;
 
//  System.Console.WriteLine($"number = {number}");
// Console.WriteLine($"{number1}{number3}");


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным превому
// Если число 2 кратно 1, то выводим "кратно". Если не кратно то выводим остаток от деления.

System.Console.Clear();

System.Console.WriteLine("Enter number 1");
string strnumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(strnumber1);

System.Console.WriteLine("Enter number 2");
string strnumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(strnumber2);

int result = number1 % number2;

if  (result == 0)
{
    System.Console.WriteLine("Кратно");
}

else 
{
    System.Console.WriteLine($"Остаток от деления = {result}");
}