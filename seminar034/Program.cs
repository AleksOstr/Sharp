// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.Clear();
var rand = new Random();
void FillMatrix(int[,] matrix)                              // Заполнение массива случайными числами
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
bool ValueWasUsed(int number, int[,] matrix)                // Метод, определяющий наличие элемента в массиве
{
    bool numExists = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (number == matrix[i, j])
            {
                numExists = true;
                break;
            }
        }

    }
    if (!numExists) return false;
    else return true;
}
void ShowCountOfRepetitons(int number, int[,] matrix)           // Метод, определяющий количество повторений определенного элемента в массиве
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (number == matrix[i, j]) count++;
        }
    }
    Console.WriteLine($"Элемент {number} встречается {count} раз");
}

int rows = rand.Next(2, 10);
int cols = rand.Next(2, 10);
int[,] numbers = new int[rows, cols];
FillMatrix(numbers);
PrintMatrix(numbers);
Console.WriteLine();

int[,] usedValues = new int[rows, cols];                        // Массив для значений элементов, количество повторений которых мы уже посчитали
bool valueUsed;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        valueUsed = ValueWasUsed(numbers[i, j], usedValues);
        if (!valueUsed)
        {
            ShowCountOfRepetitons(numbers[i, j], numbers);
            usedValues[i, j] = numbers[i, j];
        }
    }
}