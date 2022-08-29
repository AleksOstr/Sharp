// spiral
Console.Clear();

var rand = new Random();
int rows = rand.Next(4, 11);
int cols = rows;
int[,] numbers = new int[rows, cols];


int value = 1;

for (int shift = 0; shift < numbers.GetLength(0) - 2; shift++)
{
    for (int j = 0 + shift; j < numbers.GetLength(1) - shift; j++)
    {
        numbers[0 + shift, j] = value;
        value++;
    }
    value--;
    for (int i = 0 + shift; i < numbers.GetLength(0) - shift; i++)
    {
        numbers[i, numbers.GetLength(1) - 1 - shift] = value;
        value++;
    }
    value--;
    for (int j = numbers.GetLength(1) - 1 - shift; j >= 0 + shift; j--)
    {
        numbers[numbers.GetLength(0) - 1 - shift, j] = value;
        value++;
    }
    value--;
    for (int i = numbers.GetLength(0) - 1 - shift; i > 0 + shift; i--)
    {
        numbers[i, 0 + shift] = value;
        value++;
    }
    
}

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (numbers[i, j] < 10) Console.Write($"[{numbers[i, j]}]  ");
        else Console.Write($"[{numbers[i, j]}] ");
    }
    Console.WriteLine();
}

