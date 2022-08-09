// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string number = Console.ReadLine();
char[] array = number.ToCharArray();

if (array.Length <= 2)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    Console.WriteLine(array[2]);
}