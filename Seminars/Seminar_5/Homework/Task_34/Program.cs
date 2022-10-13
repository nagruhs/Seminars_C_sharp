﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Метод создания массива c рандомными числами (minlenght - минимальная длина массива, maxlenght - максимальная длина массива, mindigit - минимальное число в значении, maxdigit - максимальное число в значении)

int[] RandomArr(int minlenght, int maxlenght, int mindigit, int maxdigit)
{
    int[] array = new int[new Random().Next(minlenght, maxlenght + 1)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(mindigit, maxdigit + 1);
    }
    return array;
}


// вывод массива на экран
void PrintArray(int[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write("]");
}


// метод подсчета количества четных чисел
int Count(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}


// программа
Console.Clear();
int[] ArrayResult = RandomArr(5, 10, 100, 999);
int count = Count(ArrayResult);

Console.Write("В массиве: ");
PrintArray(ArrayResult);
Console.WriteLine($" количество четных чисел = {count}");
