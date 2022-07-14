// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void SecondDigit (int num)
{
    if (num > 99 && num < 1000)
    {
        int a = num/10;
        Console.WriteLine($"Second digit is {a % 10}");
    }

    else
    Console.WriteLine("It is not tree-digit number");
}

Console.WriteLine("Write a three-digit number: ");
int s_a = int.Parse(Console.ReadLine());

SecondDigit (s_a);

