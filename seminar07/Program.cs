// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int a = num / 100;
int b = num % 10;
Console.WriteLine($"{a}{b}");