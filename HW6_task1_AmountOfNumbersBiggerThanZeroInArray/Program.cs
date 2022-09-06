// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

Console.Write($"Сколько чисел вы хотите ввести (число М): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[m];

void inputNumbers(int m)
    {
        for (int i = 0; i < m; i++)
        {
            Console.Write($"Введи {i+1}е число and press 'Enter': ");
            arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

int Comparison(int[] arrayNumbers)
    {
        int count = 0;
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            if(arrayNumbers[i] > 0 ) count += 1; 
        }
        return count;
    }

inputNumbers(m);
Console.WriteLine($"Чисел больше 0: {Comparison(arrayNumbers)} ");