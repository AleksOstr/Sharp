// Задайте массив из 123 случайных чисел. Найдите количество элементов массива, лежащих в отрезке [10, 99]

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-200, 201);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] numbers = new int[123];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 10 && numbers[i] <= 99) count += 1;
}
Console.WriteLine($"Количество чисел в отрезке [10,99] равно {count}");