/* 3.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0 )
{
   Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
} 


/* PS C:\Users\poval\Desktop\Homework C#1\№3> dotnet run
Введите число: 
4
Да
PS C:\Users\poval\Desktop\Homework C#1\№3> dotnet run
Введите число: 
-3
Нет
PS C:\Users\poval\Desktop\Homework C#1\№3> dotnet run
Введите число: 
7
Нет
PS C:\Users\poval\Desktop\Homework C#1\№3> 
 */