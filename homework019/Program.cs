﻿// Задача 47. Задайте двумерный массив размером m x n,
// заполненный случайными вещественными числами.

Console.Clear();

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int mult = new Random().Next(-100, 100);
            matrix[i, j] = Math.Round(new Random().NextDouble() * mult, 2);
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];
FillMatrix(numbers);
PrintMatrix(numbers);