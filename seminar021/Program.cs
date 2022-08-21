// Напишите программу замены элементов массива: поменять положительные элементы на соотвествуеющие отрицательные, и наоборот.
Console.Clear();

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-50, 51);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ChangePosToNeg(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] numbers = new int[10];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
ChangePosToNeg(numbers);
PrintArray(numbers);