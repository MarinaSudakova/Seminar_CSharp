// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumNum (int a)
{
    int sum = 0;
    while (a>1)
    {
        sum = sum + a%10; //2
        a = a/10; //1
    }
    return sum;
}

Console.WriteLine ("Write a number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine (SumNum (num));
