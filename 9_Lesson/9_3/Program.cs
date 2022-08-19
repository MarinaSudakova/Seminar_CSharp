// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int SumForNum (int num)
{
    if (num < 1) return 0;
    return SumForNum (num/10) + num%10;
}
Console.WriteLine(SumForNum (123));
