// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

void Pallindrom (int num)
{
    if (num < 99999 && num > 10000)
    {
        if (num/10000 == num%10 && num/1000 % 10 == num/10 % 10)
        Console.WriteLine("Yes");

        else
        Console.WriteLine("No");
    }
    else
    Console.WriteLine("Not a five-digit number!");
}

Console.Write("Write a five-digit number: ");
int s_a = int.Parse(Console.ReadLine());

Pallindrom(s_a);