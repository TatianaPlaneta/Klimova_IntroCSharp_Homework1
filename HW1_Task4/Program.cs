// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// 

задача пока не решена

void PrintNumbers(int num1, int num2)
        {
        // for (int i=num1; i < num2+1; i++) Console.Write($"{i}, ");
            for (int i = num1; i < num2+1; i++) Console.Write(i+", ");
            Console.WriteLine();
        }

        PrintNumbers(1,10);
        PrintNumbers (1,21);
        PrintNumbers (1,6);
        






// if (N%2 == 1 && 1 > N > ) 


// while (count > 1 && count <= x)
// {
//     count = count + 2
// }
// Console.WriteLine

// for (int i = 1; i <= x; i = x%2==0, i++) Console.Write(i+", ");



// Console.Write("b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Является ли b квадратом a?");
// if (b == a * a) Console.WriteLine ("Yes");
// else Console.WriteLine ("No");

// int a = Convert.ToInt32(Console.ReadLine());
// if (a%2==0) Console.WriteLine("Это число является четным");

// Console.WriteLine("Введите целое трехзначное число:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(x%10);

// string x = Console.ReadLine();
// // //[456] 0 - 4, 1 - 5, 2 - 6
// // Console.Write(x[2]);

// N = int(input())
// A = 0
// if N % 2 == 1:
//     A = N - 1 
// else:
//     A = N
// x = 0
// a = []
// while x != A:
//     x += 2
//     a.append(x)
// for elem in a:
//     print(elem, end=' ')