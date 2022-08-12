// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    Console.Write($"{Math.Pow(count, 2)} ");
    count++;
}