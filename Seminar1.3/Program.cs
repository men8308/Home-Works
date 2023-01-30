// Нипишите программу, которая будет выдават
// название лня недели по заданному номеру

// 3 -> среда
// 5 -> пятница

Console.Write("enter number :");
string strNumber = Console.ReadLine();
int Number1 = Convert.ToInt32(strNumber);
if (Number1 == 1) 
{
System.Console.WriteLine("Это понедельник");
}
else if (Number1 == 2)
{
System.Console.WriteLine("Это вторник");
}
else if (Number1 == 3)
{
System.Console.WriteLine("Это среда");
}
else if (Number1 == 4)
{
System.Console.WriteLine("Это четверг");
}
else if (Number1 == 5)
{
System.Console.WriteLine("Это пятница");
}
else if (Number1 == 6)
{
System.Console.WriteLine("Это суббота");
}
else if (Number1 == 7)
{
System.Console.WriteLine("Это воскресение");
}
else System.Console.WriteLine("Нет такого дня недели");

switch(Number1)
{
    case 1: Console.WriteLine("Monday"); break;
    
    case 2: Console.WriteLine("Tuesday"); break;

    case 3: Console.WriteLine("Wednesday"); break;

    case 4: System.Console.WriteLine("Thursday"); break;

    case 5: System.Console.WriteLine("Friday"); break;

    case 6: System.Console.WriteLine("Saturday"); break;

    case 7: Console.WriteLine("Sunday"); break;

    default: Console.WriteLine("Bad number"); break;
}