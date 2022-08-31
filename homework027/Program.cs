// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();
var rand = new Random();
int m = rand.Next(1, 101);
int n = rand.Next(1, 101);
Console.WriteLine($"M = {m} N = {n}");
if (m > n)
{
    for (int i = n; i <= m; i++)
    {
        Console.Write($"{i} ");
    }
}
else if (n > m)
{
    for (int i = m; i <= n; i++)
    {
        Console.Write($"{i} ");
    }
}
else if (m == n)
{
    Console.WriteLine("Числа равны");
}