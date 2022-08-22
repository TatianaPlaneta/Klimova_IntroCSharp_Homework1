// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа a, b, с: ");
Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Maximum:");
if (a > b && a > c) Console.WriteLine(a);
if (b > a && b > c) Console.WriteLine(b);
if (c > a && c > b) Console.WriteLine(c);