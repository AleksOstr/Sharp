// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();
int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return A(m - 1, 1);
    else if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    else
    {
        Console.WriteLine("Функция только для неотрицательных чисел");
        return -1;
    }
}
int ackermann = A(3, 3);
Console.WriteLine(ackermann);