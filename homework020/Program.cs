// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int FindInMatrix(int[,] matrix, int row, int col)           // Поиск элемента по позиции
{
    if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1)) return matrix[row, col];
    else
    {
        Console.WriteLine("Указанного элемента не существует");
        return -1;
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

PrintMatrix(numbers);                                       // Выводим матрицу на экран для удобства проверки работы поиска элемента по позиции

Console.WriteLine("Укажите позицию искомого элемента");     // Выполняем поиск значения элемента по его позиции
Console.Write("Строка: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int numCol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindInMatrix(numbers, numRow, numCol));