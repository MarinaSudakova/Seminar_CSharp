//Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] MassNums(int size)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(-20, 31);
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

int NotEvenPos (int[] arr)
{
    int sum = 0;
     for (int j = 0; j<arr.Length; j+=2)
    {
        sum = sum + arr[j];
    }
    return sum;
}


int[] arr_1 = MassNums(5);
ShowArray(arr_1);
Console.WriteLine (NotEvenPos (arr_1));

