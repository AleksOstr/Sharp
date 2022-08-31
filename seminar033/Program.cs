// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int rows1 = rand.Next(3, 10);
int cols1 = rand.Next(3, 10);
int rows2 = cols1;
int cols2 = rows1;

int[,] numbers = new int[rows1, cols1];
int[,] result = new int[rows2, cols2];
FillMatrix(numbers);
PrintMatrix(numbers);
Console.WriteLine();
if (rows1 == cols1)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            result[i, j] = numbers[j, i];
        }
    }
}
else
{
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            result[i, j] = numbers[j, i];
        }
    }
}
PrintMatrix(result);
