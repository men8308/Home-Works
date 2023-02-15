// Задача №39. Напишите рограмму, которая перевернет одномерный массив

Console.Clear();

// int EnterNumber (string number)
// {
//     Console.WriteLine($"Enter {number}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// int ArraySize = EnterNumber("array size");
// int minValue = EnterNumber("minvalue for array");
// int maxValue = EnterNumber("maxvallue for array");
// // int Result = 0;
// // Console.WriteLine();

// int [] numbers = CreateArray(ArraySize, minValue, maxValue);

// Console.Write(string.Join(" ", numbers));
// Console.WriteLine();
// Console.WriteLine(string.Join(" ", ReversArray(numbers)));


// int [] ReversArray (int [] set)
// {
    
//     for (int i = 0; i < set.Length/2; i++)
//     {
//         int temp = set [i];
//         set [i] = set [set.Length - 1 - i];
//         set [set.Length - 1 -i] = temp;
//     } 
//     return set;
// }


// Второй вариант решения этой задачи
// #nullable disable

// System.Console.WriteLine("Enter array legth: ");
// int length = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Enter array minimal: ");
// int min = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Enter array maximal: ");
// int max = int.Parse(Console.ReadLine());

// int[] MyArray = GetArray(length, min, max);

// System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");

// int[] GetArray (int size, int minValue, int maxValue)
// {
// Random rnd = new Random();
// int[] result = new int[size];
// for(int i = 0; i < result.Length; i++)
// {
// result[i] = rnd.Next(minValue, maxValue+ 1);
// }
// return result;
// }

// Array.Reverse(MyArray);

// System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");




// Задача №40. Напишите прорамму, которая приниммает на вход три числа и проверяет, моет ли существовать тркугольниксо сторонами такой длины?

// #nullable disable

// System.Console.WriteLine("enter side length A ");
// int A = int.Parse(Console.ReadLine());

// System.Console.WriteLine("enter side length B");
// int B = int.Parse(Console.ReadLine());

// System.Console.WriteLine("enter side length A");
// int C = int.Parse(Console.ReadLine());

// bool IsTriangle(int a,int b,int c)
// {
// return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
// }
// if (IsTriangle(A, B, C))
// {
// System.Console.WriteLine("Can exist ");
// }
// else
// {
// System.Console.WriteLine("Impossible ");
// }



// Задача №42. Напишите программу, которая будет преоббразовывать десятичное число в двоичное.

Console.Write("Enter decimal number ");
int number = Convert.ToInt32(Console.ReadLine());

int[]Numbers(int num)
{
int size = 32;
int [] result = new int [size];
for (int i = 0; i < size; i++)
{
result[i]= num % 2;
num /=2;
}
return result;
}
int[] Binary = (Numbers(number));
Array.Reverse(Binary);
Console.WriteLine("Your binary number = "+ String.Join(" ", Binary));
