﻿// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// метод создает двумерный массив int со случайными значениями:
int[,] GetInt2dArray(int rows, int columns, int maxValue, int minValue)
{
    int[,] DoubleRandom2dArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            DoubleRandom2dArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return DoubleRandom2dArray;
}

// метод вывода массива на печать
void PrintDouble2dArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void ChangeFirstLastRows(int[,] userArray)
{
    int temp;
    int n = userArray.GetLength(1);
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        temp = userArray[0, i];
        userArray[0, i] = userArray[n - 1, i];
        userArray[n - 1, i] = temp;
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное случайное число: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное случайное число: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetInt2dArray(rows, columns, maxValue, minValue);
PrintDouble2dArray(array);
ChangeFirstLastRows(array);
Console.WriteLine();
PrintDouble2dArray(array);

