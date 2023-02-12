/* 2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите перваое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdValue = Convert.ToInt32(Console.ReadLine());
int max = firstValue;
if (firstValue < secondValue)
{
   max = secondValue;
} 
if (thirdValue > max)
{
   max = thirdValue;
} 
Console.WriteLine("Максимальное число: " + max);


/* PS C:\Users\poval\Desktop\Homework C#1\№2> dotnet run
Введите перваое число: 
2
Введите второе число: 
3
Введите третье число: 
7
Максимальное число: 7
PS C:\Users\poval\Desktop\Homework C#1\№2> dotnet run
Введите перваое число: 
44
Введите второе число: 
5
Введите третье число: 
78
Максимальное число: 78
PS C:\Users\poval\Desktop\Homework C#1\№2> dotnet run
Введите перваое число: 
22
Введите второе число: 
3
Введите третье число: 
9
Максимальное число: 22 */