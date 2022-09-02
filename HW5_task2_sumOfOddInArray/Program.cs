// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива:  ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int sum = 0;

void FillRandomNumbers(int[] array)
{
    for(int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(-100,100);
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

for (int i = 0; i < a; i++)
    {
        if (i % 2 == 1) sum = sum + array[i];
    }

Console.WriteLine("Сумма элементов нечетных индексов: " + sum);