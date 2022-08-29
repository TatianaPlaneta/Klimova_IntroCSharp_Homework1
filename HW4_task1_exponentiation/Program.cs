// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;

    for (int i = 1; i < b; i++)
    {
        stepen = stepen * a;
    }
    Console.WriteLine("A в степени B равно: " + stepen);

// Решение с помощью функции Math.Pow
 
// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("А в степени В = " + Math.Pow(a, b));
