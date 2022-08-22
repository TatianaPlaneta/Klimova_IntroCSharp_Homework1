// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два целых числа a и b:");
Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Maximum:");
if (a > b) Console.WriteLine(a);
else Console.WriteLine(b);