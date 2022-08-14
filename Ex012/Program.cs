// Виды методов

// Вид 1 - Ничего не принимают, ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();      // Вызов метода


// Вид 2 - Принимают аргументы на вход, ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); // Вызов метода

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Пробное сообщение", count: 3);   // Вызов метода

// Вид 3 - Ничего не принимают, что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Видд 4 - Что-то принимают, что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z ");
Console.WriteLine(res);