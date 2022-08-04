// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int [] FillArray(int num)
{
    int[] array = new int[num];
    for (int i=0; i<num; i++)
    {
        array[i] = new Random().Next(1, 30);
    }
    return array;
}


void ShowArray(int[] coll)
{
    for (int ind = 0; ind < coll.Length; ind++)
    {
        Console.Write ($"{coll[ind]} ");
    }
}

ShowArray (FillArray(8));

