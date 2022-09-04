// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
int SumIntegersFromMtoN(int m, int n)
{
    if (n < m) return 0;
    else return n + SumIntegersFromMtoN(m, n - 1);
}

Console.WriteLine(SumIntegersFromMtoN(1,5));