// Написать программу, которая приветствует определенного пользователя по-особенному

Console.WriteLine("Введите ваше имя ");
string userName = (Console.ReadLine());

if(userName.ToLower() == "алексей")
{
    Console.WriteLine("Добро пожаловать домой!");
}
else
{
    Console.WriteLine("Приветствую, ");
    Console.WriteLine(userName);
}
