// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите ваше число");
int num = Convert.ToInt32(Console.ReadLine());
int count = num * -1;

while (count <= num)
{
    Console.Write($"{count} ");
    count++;
}
