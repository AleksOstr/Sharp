// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки через запятую(,)");
double[] startPoint = Console.ReadLine().Split(',').Select(double.Parse).ToArray();
Console.WriteLine("Введите координаты второй точки через запятую(,)");
double[] endPoint = Console.ReadLine().Split(',').Select(double.Parse).ToArray();

double distance = Math.Round(Math.Sqrt(Math.Pow(endPoint[0] - startPoint[0], 2) + Math.Pow(endPoint[1] - startPoint[1], 2) + Math.Pow(endPoint[2] - startPoint[2], 2)), 2);
Console.WriteLine($"Расстояние между точками составляет {distance}");