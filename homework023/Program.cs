// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
void FillMatrix(int[,] matrix)                              // Заполнение массива случайными целыми числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 21);
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

int rows = new Random().Next(3, 11);
int cols = new Random().Next(2, 10);
int[,] numbers = new int[rows, cols];
FillMatrix(numbers);
PrintMatrix(numbers);
Console.Write("Сумма элементов каждой строки: ");
int[] sumOfRows = new int[numbers.GetLength(0)];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sumOfRows[i] += numbers[i, j];
    }
    Console.Write($"({sumOfRows[i]}) ");
}
Console.WriteLine();
int minRow = sumOfRows[0];
int minRowIndex = 0;
for (int i = 0; i < sumOfRows.Length; i++)
{
    if (sumOfRows[i] < minRow)
    {
        minRow = sumOfRows[i];
        minRowIndex = i;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRowIndex + 1} строка");