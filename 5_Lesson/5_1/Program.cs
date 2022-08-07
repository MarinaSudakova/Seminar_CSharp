// 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, 
//и наоборот.

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

void Change (int[] arr)
{
     for (int j = 0; j<arr.Length; j++)
    {
        arr[j] = arr [j] * -1;
    }
}


int[] arr_1 = MassNums(12, -9, 10);
ShowArray(arr_1);
Change (arr_1);
ShowArray(arr_1);



