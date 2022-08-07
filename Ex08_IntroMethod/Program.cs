// Тыкаем в методы. Метод поиска максимального числа

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 32;
int c1 = 85;
int a2 = 23;
int b2 = 51;
int c2 = 12;
int a3 = 76;
int b3 = 24;
int c3 = 90;

/* int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3); */
//Вместо использования трех отдельных переменных, аргументы можно представить в виде метода.

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);