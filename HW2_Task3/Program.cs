﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7, где 1 - понедельник:");
Console.Write("День недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 5) Console.WriteLine("Это будний день.");
else Console.WriteLine("Это выходной день.");

//как исключить числа больше 8?