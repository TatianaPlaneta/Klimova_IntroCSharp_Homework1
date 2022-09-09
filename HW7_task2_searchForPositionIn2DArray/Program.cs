﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4        // 17 -> такого числа в массиве нет

Console.Write("Введите количество строк двумерного массива, m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива, n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,10));  
    }
 
for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
    }

Console.Write("Введите координату строки а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату столбца b: ");
int b = Convert.ToInt32(Console.ReadLine());
 
if (a > m-1 | b > n-1) Console.WriteLine("Числа с такими координатами в данном массиве нет.");
else
    {
    object c = array.GetValue(a,b);
    Console.WriteLine("В заданном массиве это число: " + c);
    }