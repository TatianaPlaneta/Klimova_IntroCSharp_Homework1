// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива:  ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

void FillRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < a - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[a - 1] + "]");
}

FillRandomNumbers(array);
ShowArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine($"Количество четных чисел в этом массиве -> {count}.");

// Код без функции:
//
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];

// for (int i = 0; i < N; ++i) 
//     {
//         array[i] = new Random().Next(100, 1000);
//     }

// Console.Write("[");
// for (int i = 0; i < N - 1; ++i) 
//     {
//         Console.Write(array[i] + ", ");
//     }
// Console.WriteLine(array[N - 1] + "]");

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// if (array[i] % 2 == 0)
// count++;

// Console.WriteLine($"Количество четных чисел в этом массиве -> {count}.");