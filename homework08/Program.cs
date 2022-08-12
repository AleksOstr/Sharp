// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10000 && num <= 99999)
{
    if (num / 10000 == num % 10 && num % 10000 / 1000 == num % 100 / 10)
    {
        Console.WriteLine($"Число {num} - является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} - не является палиндромом");
    }
}
else
{
Console.WriteLine($"Число {num} - не является пятизначным");
}
