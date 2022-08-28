// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortMatrixRowsMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int h = j + 1; h < matrix.GetLength(1); h++)
            {
                if (matrix[i, h] > matrix[i, maxPosition]) maxPosition = h;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxPosition];
            matrix[i, maxPosition] = temp;
        }
    }
}

Console.WriteLine("Задайте количество строк массива");      // Задаем размеры матрицы и заполняем случайными числами
int rows = Convert.ToInt32(Console.ReadLine());
while (rows < 2)
{
    Console.WriteLine("Количество строк не может быть меньше 2");
    Console.WriteLine("Повторите ввод значения");
    rows = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Задайте количество столбцов массива");
int cols = Convert.ToInt32(Console.ReadLine());
while (cols < 2)
{
    Console.WriteLine("Количество столбцов не может быть меньше 2");
    Console.WriteLine("Повторите ввод значения");
    cols = Convert.ToInt32(Console.ReadLine());
}
int[,] numbers = new int[rows, cols];
FillMatrix(numbers);
PrintMatrix(numbers);
Console.WriteLine();
SortMatrixRowsMaxToMin(numbers);
PrintMatrix(numbers);