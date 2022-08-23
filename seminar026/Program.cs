// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Задайте число 1");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число 3");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.WriteLine("Треугольник с такими сторонами существует");
else Console.WriteLine("Треугольник с такими сторонами не существует");