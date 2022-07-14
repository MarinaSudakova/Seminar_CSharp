// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void WhatDay (int day)
{
    if (day > 0 && day < 6)
    Console.WriteLine ("Sorry, it is a working day:(");

    else if (day > 5 && day < 8)
    Console.WriteLine ("Congrats, it is a weekend:)");

    else
    Console.WriteLine ("Unknowing day");
}

Console.WriteLine("Please, write number of the day: ");
int s_a = int.Parse(Console.ReadLine());
WhatDay(s_a);
