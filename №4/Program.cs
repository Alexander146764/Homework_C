/*  4.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
while(n <= number)
{
    if(n % 2 ==0)
    {
        Console.Write(n + ",");
    }
    n++;
}


/* PS C:\Users\poval\Desktop\Homework C#1\№4> dotnet run
Введите число
5
2,4,
PS C:\Users\poval\Desktop\Homework C#1\№4> dotnet run
Введите число
8
2,4,6,8,
PS C:\Users\poval\Desktop\Homework C#1\№4> */