//Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

void Pallindrom (string num)
{
    int length = num.Length;
    if (num.Length == 5)
    {
        if (num[0] == num[4] && num[1] == num[3])
        Console.WriteLine("Yes");

        else
        Console.WriteLine("No");
    }
    else
    Console.WriteLine("Not a five-digit number!");
}

Console.Write("Write a five-digit number: ");
string s_a = Console.ReadLine();

Pallindrom(s_a);
