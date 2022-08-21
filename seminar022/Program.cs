// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string FindInArray(int[] arr, int number)
{
    string result = $"Числа {number} в массиве нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            result = $"Число {number} в массиве есть";
            break;
        }
    }
    return result;
}

int[] randomArray = new int[10];

FillArray(randomArray);
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine(FindInArray(randomArray, 5));