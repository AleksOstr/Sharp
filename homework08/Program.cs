// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
string number = num.ToString();

if (number.Length != 5)
{
    Console.WriteLine("Это не пятизначное число");
}
else if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine($"Число {num} - палиндром");
}
else
{
    Console.WriteLine($"Число {num} - не палиндром");
}
