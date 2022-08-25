// Составить программу нахождения минимального значения
// среди элементов любой строки двумерного массива

Console.Clear();

void FillMatrix(int[,] matrix)                              // Заполнение массива случайными целыми числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 101);
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

int FindMinimumInRow(int[,] matrix, int row)                // Поиск минимального элемента в определенной строке двумерного массива
{
    int minElement = matrix[row, 0];
    for (int i = 1; i < matrix.GetLength(1); i++)
    {
        if (matrix[row, i] < minElement) minElement = matrix[row, i];
    }
    return minElement;
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

Console.WriteLine("В какой строке искать минимум?");
int rowForSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Значение минимального элемента в строке {rowForSearch} составляет {FindMinimumInRow(numbers, rowForSearch)}");