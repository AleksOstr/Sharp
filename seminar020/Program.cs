// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9; 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] numbers = new int[12];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-9, 10);
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sumPositive += numbers[i];
    }
    else if (numbers [i] < 0)
    {
        sumNegative += numbers[i];
    }
}
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");