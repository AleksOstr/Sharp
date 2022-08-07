// Имеется одномерный массив из n элементов. Требуется найти элемент массива, равный find.

int[] array = { 14, 21, 31, 41, 15, 61, 37, 28 };

int n = array.Length;

Console.WriteLine("Введите значение искомого элемента");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Индекс искомого элемента равен {index}");
        break;
    }
    index++;
}