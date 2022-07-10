// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Write a three-digit number: ");
int a = int.Parse(Console.ReadLine());

if (a < 100)
Console.WriteLine("What's wrong with you, not a three-digit number!");

else if (a >= 1000)
Console.WriteLine("What's wrong with you, not a three-digit number!");

else
Console.WriteLine(a%10);

