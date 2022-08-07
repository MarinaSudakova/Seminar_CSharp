// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int [] FillArray()
{
    int size = 8;
    int[] array = new int[size];
    for (int i=0; i<size; i++)
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

int[] arr_1 = FillArray();
ShowArray(arr_1);


