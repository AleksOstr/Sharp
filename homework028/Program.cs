// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
var rand = new Random();
int m = rand.Next(1, 101);
int n = rand.Next(1, 101);
Console.WriteLine($"M = {m} N = {n}");
int sumOfIntegers = 0;
if (m > n)
{
    for (int i = n; i <= m; i++)
    {
        sumOfIntegers += i;
    }
    Console.Write($"Сумма натуральных элементов равна {sumOfIntegers}");
}
else if (n > m)
{
    for (int i = m; i <= n; i++)
    {
        sumOfIntegers += i;
    }
    Console.Write($"Сумма натуральных элементов равна {sumOfIntegers}");
}
else if (m == n)
{
    Console.WriteLine("Числа равны");
}
