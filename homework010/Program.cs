// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;

if (n <= 0)
{
    Console.WriteLine("Число не может быть меньше 1");
}
else
{
    while (index <= n)
    {
        Console.Write($"{Math.Pow(index, 3)} ");
        index++;
    }
}