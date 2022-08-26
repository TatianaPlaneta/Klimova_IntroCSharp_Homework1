// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите целое пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
string y = Convert.ToString(x);

void CorrectNumber(string number)
    {
        if (y[0] == y[4] && y[1] == y[3]) Console.WriteLine("Данное число является палиндромом.");
        else Console.WriteLine("Данное число не является палиндромом.");
    }

if (y!.Length == 5) 
    {
        CorrectNumber(y);
    }
        else Console.WriteLine("Вы ввели неправильное число. Перезапустите программу и введите пятизначное число.");