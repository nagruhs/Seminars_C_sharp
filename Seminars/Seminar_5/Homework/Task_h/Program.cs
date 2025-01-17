﻿//// *** замер времени выполнения
// using System;
// using System.Diagnostics;
// using System.Threading;

// public class Example
// {
//     public static void Main()
//     {
//         Stopwatch stopwatch = new Stopwatch();

//         stopwatch.Start();
//         Thread.Sleep(5000);


// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[] GetSort(int[] array)
{
    int sortedsize = 0;
    while (sortedsize < array.Length - 1)
    {
        int i = 0;
        while (i < array.Length - 1 - sortedsize)
        {
            if (array[i] < array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                // array[i] = array[i] + array[i + 1];
                // array[i + 1] = array[i] - array[i + 1];
                // array[i] = array[i] - array[i + 1];



            }
            i++;
        }
        sortedsize++;

    }
    return array;
}

// int[] myarray1 = GetArray(10, -10, 10);
// Array.Copy(myarray, myarray1, 10);


// программа
Console.Clear();
int[] myarray = GetArray(10, -10, 10);
// int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
Console.WriteLine($"Изначальный массив: {String.Join(", ", myarray)}");
int[] newarray = GetSort(myarray);
Console.WriteLine($"Отсортированный массив: {String.Join(", ", newarray)}");








// Console.WriteLine($"Изначальный массив: {String.Join(", ", myarray1)}");

// *** замер времени выполнения
//         stopwatch.Stop();

//         Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
//     }
// }