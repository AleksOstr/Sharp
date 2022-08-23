// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-200, 201);
    }
}

Console.WriteLine("Задайте длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];
FillArray(array);
PrintArray(array);
int temp = 0;

for (int i = 0; i < length / 2; i++)
{
    temp = array[i];
    array[i] = array[length - 1 - i];
    array[length - 1 - i] = temp;
}
Console.WriteLine();
PrintArray(array);