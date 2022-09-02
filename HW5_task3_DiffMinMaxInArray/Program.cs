// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива:  ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];

void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + "; ");
        }
   Console.WriteLine(array[a - 1] + "]");
}

FillArrayRandomNumbers(array);
PrintArray(array);

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int b = 0; b < array.Length; b++)
{
    if (array[b] > max)
        {
            max = array[b];
        }
    if (array[b] < min)
        {
            min = array[b];
        }
}
    Console.WriteLine($"Разница между максимальным и минимальным значением равна {max - min}");