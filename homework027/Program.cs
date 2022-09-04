// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();
void NumbersFormMToN(int m, int n)
{
    if (n != m)
    {
       NumbersFormMToN(m, n - 1);
    }
    Console.Write($"{n} ");
}

int a = new Random().Next(1, 11);
int b = new Random().Next(15, 21);
NumbersFormMToN(a, b);
