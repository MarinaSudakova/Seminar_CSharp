// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void FromOne (int num)
{
    if (num == 0) return;
    FromOne (num - 1);
    Console.Write($" {num}, ");
}

FromOne(5);
