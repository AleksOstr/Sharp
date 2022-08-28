// Задача 47. Задайте двумерный массив размером m x n,
// заполненный случайными вещественными числами.

Console.Clear();

void FillMatrix(double[,] matrix)                                               // Заполнение массива случайными вещественными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int mult = new Random().Next(-100, 100);
            matrix[i, j] = Math.Round(new Random().NextDouble() * mult, 2);
        }
    }
}

void PrintMatrix(double[,] matrix)                                              // Вывод массива на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}] ");
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(2, 11);
int n = new Random().Next(2, 11);
double[,] numbers = new double[m, n];
FillMatrix(numbers);
PrintMatrix(numbers);