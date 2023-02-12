// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите перваое число: ");
int firstValue = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine());
if (firstValue > secondValue)
{
    Console.WriteLine("Первое число: " + firstValue + "больше втрого: " + secondValue);
} 
else
{
    Console.WriteLine("Второе число: " + secondValue + " больше первого: " + firstValue);
} 

/* PS C:\Users\poval\Desktop\Homework C#1\№1> dotnet run
Введите перваое число: 
5
Введите второе число: 
7
Второе число: 7 больше первого: 5
PS C:\Users\poval\Desktop\Homework C#1\№1> dotnet run
Введите перваое число: 
2
Введите второе число: 
10
Второе число: 10 больше первого: 2
PS C:\Users\poval\Desktop\Homework C#1\№1> dotnet run
Введите перваое число: 
-9
Введите второе число: 
-3
Второе число: -3 больше первого: -9
PS C:\Users\poval\Desktop\Homework C#1\№1>  */