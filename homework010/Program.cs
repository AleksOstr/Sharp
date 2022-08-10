// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= n)
{
    Console.Write($"{Convert.ToInt32(Math.Pow(index, 3))} ");
    index++;
}