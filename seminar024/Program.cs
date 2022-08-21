// Найдите произведение пар чисел в массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результаты запишите в новый массив

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

Console.WriteLine("Задайте длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[length];
int[] result = new int[nums.Length / 2];

FillArray(nums);
PrintArray(nums);
Console.WriteLine();

for (int i = 0; i < result.Length; i++)
{
    result[i] = nums[i] * nums[nums.Length - 1 - i];
}
PrintArray(result);



