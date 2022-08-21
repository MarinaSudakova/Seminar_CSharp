//Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNums (int a, int b)
{
    if (b < a) return 0;
    return SumNums(a, b - 1) + b;
}

Console.WriteLine (SumNums(4, 8));