// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowIntegersFromNTo1(int n)
{
    if (n != 1)
    {
        ShowIntegersFromNTo1(n - 1);
    }
    Console.Write($"{n} ");
}

int n = 5;
ShowIntegersFromNTo1(n);