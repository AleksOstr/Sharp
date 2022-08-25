// Дан двумерный массив
// 1. Найти максимальный элемент
// 2. Найти минимальный элемент
// 3. Найти координаты максимального элемента 
// (если элементов с максимальным значением несколько, то должны быть найдены координаты всех совпадающих элементов)
// 4. Найти координаты минимального элемента
// (если элементов с минимальным значением несколько, то должны быть найдены координаты всех совпадающих элементов)

Console.Clear();

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

int maxElement = numbers[0, 0];
int minElement = numbers[0, 0];
string maxIndex = "";
string minIndex = "";
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (numbers[i, j] > maxElement)
        {
            maxElement = numbers[i, j];
            maxIndex = $"[{i.ToString()}, {j.ToString()}]";
        }
        else if (numbers[i, j] == maxElement) maxIndex += $" [{i.ToString()}, {j.ToString()}]";
        else if (numbers[i, j] < minElement)
        {
            minElement = numbers[i, j];
            minIndex = $"[{i.ToString()}, {j.ToString()}]";
        }
        else if (numbers[i, j] == minElement) minIndex += $" [{i.ToString()}, {j.ToString()}]";
    }
}
Console.WriteLine($"Максимальный элемент равен {maxElement}, координаты {maxIndex}");
Console.WriteLine($"Минимальный элемент равен {minElement}, координаты {minIndex}");