// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.WriteLine("Укажите количество вводимых чисел");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.WriteLine("Указано неверное количество чисел. Количество вводимых чисел должно быть >0. Повторите ввод");
    m = Convert.ToInt32(Console.ReadLine());
}

int[] numbers = new int[m];

int count = 0;
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите {i + 1} число");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    if (numbers[i] > 0) count++;
}

Console.WriteLine($"Было введено {count} чисел больше 0");