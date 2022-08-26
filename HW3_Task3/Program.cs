// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Первый вариант:

// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     Console.Write(i*i*i+", ");
// }

// Второй вариант:

void CubicTableN()
{
    Console.Write("Введите целое положительное число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] answer = new int[N];
    if (N > 0)
    {
        for (int i = 1; i < (N + 1); i++)
        {
            answer[i - 1] = (i * i * i);
        }
    }
    else
        {
            Console.Write("Надо было ввести положительное целое число. Перезапустите программу.");
        }
    var str = string.Join(" ", answer);
    Console.WriteLine(str);
}
    try
    {
    CubicTableN();
    }
    catch
    {
    Console.Write("Надо было ввести положительное целое число. Перезапустите программу.");
    }