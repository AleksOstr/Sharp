// Че-то там с массивом из 8 рандомных 0 и 1

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);