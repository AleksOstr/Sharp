// Самостоятельные попытки работы с массивами и методами

void FillArray(int[] collection) // Метод,  заполняющий массив случайными целыми числами в диапазоне [1; 20)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 20);
        index++;
    }
}

void PrintArray(int[] collection) // Метод, выводящий массив на экран в одну строку
{
    int index = 0;
    while (index < collection.Length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
    Console.WriteLine();
}

int FindInArray(int[] collection, int find) // Метод, возвращающий индекс искомого элемента в массиве (по первому совпадению)
{
    int index = 0;
    int position = -1;
    while (index < collection.Length)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

Console.WriteLine("Введите размер массива: ");              // Задаем размер массива с консоли
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];                              // Заолняем массив случайными целыми числами
FillArray(array);

Console.WriteLine("Введите значение искомого элемента массива: "); // Задаем значение искомого элемента массива и получаем его индекс (если такой элемент в массиве есть)
int find = Convert.ToInt32(Console.ReadLine());
int ind = FindInArray(array, find);
if (ind != -1)
{
    Console.WriteLine($"Индекс искомого элемента равен {ind}");
}
else
{
    Console.WriteLine("Искомый элемент отсутствует");
}
PrintArray(array);






