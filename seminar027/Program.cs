// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();

Console.WriteLine("Задайте число");
int num1 = Convert.ToInt32(Console.ReadLine());
string result = "";
while (num1 > 0)
{
    if (num1 % 2 != 0) result = "1" + result;
    else result = "0" + result;
    num1 /= 2;
}
Console.WriteLine(result);

