// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Degree (int a, int b)
{
    int j = a;
    for (int i=1; i<b; i++)
    {
        a = a*j;
    }
    return a;
}

Console.WriteLine ("Введите основание степени: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите степень: ");
int second = int.Parse(Console.ReadLine());

Console.WriteLine (Degree (first, second));
