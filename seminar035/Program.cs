// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива
Console.Clear();
int newRandomValue(int[,] matrix)             // Генератор неповторяющихся случайных целых чисел для двумерного массива
{
    int randomValue = new Random().Next(1, 100);
    bool numExists = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != randomValue) numExists = false;
            else
            {
                numExists = true;
                return newRandomValue(matrix);
            }
        }
    }
    if (!numExists) return randomValue;
    else return newRandomValue(matrix);
}
int[,] GetRandomMatrix()                    // Метод, возвращающий двумерный массив случайного размера
{
    int matrixRows = new Random().Next(4, 9);
    int matrixColumns = new Random().Next(4, 9);
    int[,] matrix = new int[matrixRows, matrixColumns];
    return matrix;
}
void FillMatrix(int[,] matrix)              // Заполнение двумерного массива неповторяющимися случайными целыми числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = newRandomValue(matrix);
        }
    }
}
void PrintMatrix(int[,] matrix)             // Вывод двумерного массива на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10) Console.Write($"[ {matrix[i, j]}] ");
            else Console.Write($"[{matrix[i, j]}] ");
        }
        Console.WriteLine();
    }
}
int FindMinimumInMatrix(int[,] matrix)      // Поиск минимального элемента в двумерном массиве
{
    int minElement = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement) minElement = matrix[i, j];
        }
    }
    return minElement;
}
void MoveRowToEndOfMatrix(int[,] matrix, int row)   // Перемещение строки в конец двумерного массива
{
    for (int i = row; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i + 1, j];
            matrix[i + 1, j] = temp;
        }
    }
}
void MoveColumnToEndOfMatrix(int[,] matrix, int column)         // Перемещениее столбца в конец двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = column; j < matrix.GetLength(1) - 1; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, j + 1];
            matrix[i, j + 1] = temp;
        }
    }
}
int[,] numbers = GetRandomMatrix();
FillMatrix(numbers);
PrintMatrix(numbers);
Console.WriteLine();
int minimumOfMatrix = FindMinimumInMatrix(numbers);
int rowWithMinElement = 0;
int colWithMinElement = 0;
for (int i = 0; i < numbers.GetLength(0); i++)                  // Поиск строки и столбца, в которых находится минимальный элемент
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (numbers[i, j] == minimumOfMatrix)
        {
            rowWithMinElement = i;
            colWithMinElement = j;
            break;
        }
    }
}
Console.WriteLine($"Минимальный элемент равен {minimumOfMatrix}, "
                    + $"строка {rowWithMinElement + 1}, "
                    + $"столбец {colWithMinElement + 1}");
Console.WriteLine();
MoveRowToEndOfMatrix(numbers, rowWithMinElement);
MoveColumnToEndOfMatrix(numbers, colWithMinElement);
int[,] result = new int[numbers.GetLength(0) - 1, numbers.GetLength(1) - 1];
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        result[i, j] = numbers[i, j];
    }
}
PrintMatrix(result);