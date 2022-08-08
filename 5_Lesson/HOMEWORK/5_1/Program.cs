//Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int [] MassNums(int size)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}


void ShowArray(int[] coll)
{
    for (int ind = 0; ind < coll.Length; ind++)
    {
        Console.Write ($"{coll[ind]} ");
    }
    Console.WriteLine();
}

int EvenNum (int[] arr)
{
    int sum = 0;
     for (int j = 0; j<arr.Length; j++)
    {
        if (arr[j]%2 == 0)
            sum++;
    }
    return sum;
}


int[] arr_1 = MassNums(6);
ShowArray(arr_1);
Console.WriteLine (EvenNum (arr_1));


