// 
Console.Clear();
int num = new Random().Next(10, 100);
Console.WriteLine(num);
int num2 = num / 10;
int num3 = num % 10;

if (num2 > num3)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}