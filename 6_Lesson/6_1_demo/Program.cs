// 1. Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)


int [] MassNums(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(from, to);
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

int[] RevMas(int[] arr)
{
    int size = arr.Length - 1;

    for(int i = 0; i < size / 2 + 1; i++)
        (arr[i], arr[size - i]) = (arr[size - i], arr[i]);

    return arr;
}



int[] arr_1 = MassNums(5, 1, 20);
ShowArray(arr_1);
RevMas (arr_1);
Console.WriteLine();
ShowArray (arr_1);

