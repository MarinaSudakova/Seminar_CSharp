// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

void CutNum (int num)
{
    Console.WriteLine($"{num / 100}{num%10}");
}

int number = new Random().Next(100,1000);
Console.Write($"{number} change to ");
CutNum (number);



