// напишите программу, которая на вход принимает число и выдает его квадрат (число
// умноженное само на себя)

// Например:
// 4 -> 16
// 3 -> 9
// -7 -> 49

Console.WriteLine("Enter number : ");

string strNumber = Console.ReadLine();

int number = Convert.ToInt32(strNumber);

int sqr = number * number;

Console.WriteLine(sqr);

