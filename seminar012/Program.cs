// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти ");
int q = Convert.ToInt32(Console.ReadLine());

if (q < 1 || q > 4)
{
    Console.WriteLine("Нет такой четверти");
}
else if (q == 1)
{
    Console.WriteLine("x > 0 до +ထ; y > 0 до +ထ");
}
else if (q == 2)
{
    Console.WriteLine("x < 0 до -ထ; y > 0 до +ထ");
}
else if (q == 3)
{
    Console.WriteLine("x < 0 до -ထ; y < 0 до -ထ");
}
else if (q == 4)
{
    Console.WriteLine("x > 0 до +ထ; y < 0 до -ထ");
}