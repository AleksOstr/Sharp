// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите Х (кроме 0) ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y (кроме 0)");
int y = Convert.ToInt32(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты не должны быть равны 0");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Певрая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}