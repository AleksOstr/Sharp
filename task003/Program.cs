// 

void FillMatrix(int[,] matrix)                              // Заполнение массива случайными целыми числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

int row = new Random().Next(2, 11);
int col = new Random().Next(2, 11);
int[,] numbers = new int[row, col];
FillMatrix(numbers);
PrintMatrix(numbers);

