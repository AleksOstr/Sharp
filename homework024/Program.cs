// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

void FillMatrix(int[,] matrix)                              // Заполнение массива случайными целыми числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(2, 10);
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
void MatrixMultiplication(int[,] matrixA, int[,] matrixB)   // Умножение матрицы А на матрицу В
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixB.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
                Console.Write($"[{matrixC[i, j]}] ");
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Умножение матриц невозможно, т.к. количество столбцов первой матрицы "
                        + "неравно количеству строк второй матрицы");
}

int rowsA = new Random().Next(2, 4);
int colsA = new Random().Next(2, 4);
int[,] numbersA = new int[rowsA, colsA];
FillMatrix(numbersA);
PrintMatrix(numbersA);
Console.WriteLine();

int rowsB = new Random().Next(2, 4);
int colsB = new Random().Next(2, 4);
int[,] numbersB = new int[rowsB, colsB];
FillMatrix(numbersB);
PrintMatrix(numbersB);
Console.WriteLine();
MatrixMultiplication(numbersA, numbersB);