// 11. Дано число из отрезка [10, 99]. 
// Показать наибольшую цифру числа

void FindMinimum (int a)
{
    if (a < 10 || a > 99)
        Console.WriteLine ("Impossible");
    else
    {
        if (a % 10 > a / 10)
            Console.WriteLine ($"Biggest is {a%10} ");
        else
            Console.WriteLine ($"Biggest is {a/10} ");
    }
}

Console.WriteLine("Write a number from 10 to 99: ");
int num = int.Parse (Console.ReadLine());

FindMinimum (num);
