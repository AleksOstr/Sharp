// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void NumbersFormMToN(int m, int n)
{
    if (n != m)
    {
       NumbersFormMToN(m, n - 1);
    }
    Console.Write($"{n} ");
}

int a = 4;
int b = 20;
NumbersFormMToN(a, b);
