﻿// Вводим многозначное число. Необходимо узнать и сказать  последовательность цифр этого 
// числа при просмотре слева направо упорядочена по возрастанию или нет. Например 157 - да, 1427 - нет

Console.WriteLine("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 10)
{
    if (n % 10 >= n % 100 / 10)
    {
        n = n / 10;
    }
    else
    {
        
        Console.WriteLine("Число неупорядоченное");
        break;
    }   
}
if (n < 10) 
{
    Console.WriteLine("Число упорядоченное");
}
