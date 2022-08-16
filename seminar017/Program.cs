// Напишите программу, которая принимает на вход число и выдает количество цифр в числе

void CountOfN(int num)
{
int count = 0;
for (count = 0; num != 0; count++)
{
    num = num / 10;
}
Console.WriteLine($"В числе {count} цифр");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
CountOfN(num);