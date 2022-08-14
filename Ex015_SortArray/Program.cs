// Сортировка массива
int[] array = { 2, 5, 6, 5, 2, 6, 7, 1, 1 };

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SortArrayMinToMax(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPosition]) minPosition = j;
        }
        
        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }
}

void SortArrayMaxToMin(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }
        
        int temp = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temp;
    }
}

PrintArray(array);
SortArrayMaxToMin(array);
PrintArray(array);