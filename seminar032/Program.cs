// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.Clear();
var rand = new Random();
void FillMatrix(int[,] matrix)                              // Заполнение массива по формуле: Aₘₙ = m+n
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)                             // Вывод массива на экран
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

int rows = rand.Next(3, 8);
int cols = rand.Next(3, 8);

int[,] numbers = new int[rows, cols];
int[] buffer = new int[rows];
FillMatrix(numbers);
PrintMatrix(numbers);
Console.WriteLine();

for (int j = 0; j < numbers.GetLength(1); j++)
{
    buffer[j] = numbers[0, j];
    numbers[0, j] = numbers[numbers.GetLength(0) - 1, j];
    numbers[numbers.GetLength(0) - 1, j] = buffer[j];
}
PrintMatrix(numbers);