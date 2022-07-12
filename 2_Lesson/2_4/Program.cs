// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

void Method2 (int N)
{
    if (N % 7 == 0 && N % 23 == 0)
        Console.WriteLine ("Yes");
    else
    Console.WriteLine ("No");

}

Console.WriteLine ("Write a number N: ");
int N = int.Parse(Console.ReadLine());

Method2 (N);


