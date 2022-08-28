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
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
            Console.Write($"[{matrixC[i, j]}]");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте количество строк первой матрицы");      // Задаем размеры матрицы и заполняем случайными числами
int rowsA = Convert.ToInt32(Console.ReadLine());
while (rowsA < 2)
{
    Console.WriteLine("Количество строк не может быть меньше 2");
    Console.WriteLine("Повторите ввод значения");
    rowsA = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Задайте количество столбцов первой матрицы");
int colsA = Convert.ToInt32(Console.ReadLine());
while (colsA < 2)
{
    Console.WriteLine("Количество столбцов не может быть меньше 2");
    Console.WriteLine("Повторите ввод значения");
    colsA = Convert.ToInt32(Console.ReadLine());
}
int[,] numbersA = new int[rowsA, colsA];
FillMatrix(numbersA);
PrintMatrix(numbersA);
Console.WriteLine();

Console.WriteLine("Задайте количество строк второй матрицы");      
int rowsB = Convert.ToInt32(Console.ReadLine());
while (rowsB < 2)
{
    Console.WriteLine("Количество строк не может быть меньше 2");
    Console.WriteLine("Повторите ввод значения");
    rowsB = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Задайте количество столбцов второй матрицы");
int colsB = Convert.ToInt32(Console.ReadLine());
while (colsB < 2)
{
    Console.WriteLine("Количество столбцов не может быть меньше 2");
    Console.WriteLine("Повторите ввод значения");
    colsB = Convert.ToInt32(Console.ReadLine());
}
int[,] numbersB = new int[rowsB, colsB];
FillMatrix(numbersB);
PrintMatrix(numbersB);
Console.WriteLine();

if (colsA == rowsB) MatrixMultiplication(numbersA, numbersB);
else Console.WriteLine("Умножение матриц невозможно, т.к. количество столбцов первой матрицы "
                        + "неравно количеству строк второй матрицы");