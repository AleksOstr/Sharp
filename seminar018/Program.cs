// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

void OneToA(int num)
{
    if (num >= 1)
    {
        int p = 1;
        for (int i = 1; i <= num; i++)
        {
            p = p * i;
        }
        Console.WriteLine(p);
    }
    else Console.WriteLine("Введено неверное число");

}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
OneToA(num1);
