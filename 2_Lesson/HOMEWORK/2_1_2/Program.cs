// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void SecondDigit (string num)
{
   Console.WriteLine(num[1]);
}

Console.WriteLine("Write a three-digit number: ");
string s_a = Console.ReadLine();

SecondDigit (s_a);
