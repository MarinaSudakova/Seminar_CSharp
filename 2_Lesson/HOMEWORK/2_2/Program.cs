// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

void CutNum (int num)
{
    int a = num / 100;
    int b = num%10;
    Console.WriteLine($"{a}{b}");
}

int number = new Random().Next(100,1000);
Console.Write($"{number} change to ");
CutNum (number);



