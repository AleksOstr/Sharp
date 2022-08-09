// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1) Console.WriteLine("Понедельник - рабочий день");
if (num == 2) Console.WriteLine("Вторник - рабочий день");
if (num == 3) Console.WriteLine("Среда - рабочий день");
if (num == 4) Console.WriteLine("Четверг - рабочий день");
if (num == 5) Console.WriteLine("Пятница - рабочий день");
if (num == 6) Console.WriteLine("Суббота - выходной");
if (num == 7) Console.WriteLine("Воскресенье - выходной");