//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double[] MassNums(int size)
{
    double[] array = new double [size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().NextDouble() * (20-10);
    }
    return array;
}


void ShowArray(double[] coll)
{
    for (int ind = 0; ind < coll.Length; ind++)
    {
        Console.Write ($"{coll[ind]} ");
    }
    Console.WriteLine();
}

void SumMinMax (double[] arr)
{
    int posMax = 0;
    int posMin = 0;

    for (int j = 1; j<arr.Length; j++)
    {
        if (arr[j] > arr[posMax])
            posMax = j;
        else
            if (arr[j] < arr[posMin])
                posMin = j;   
    }

    Console.WriteLine ($"Maximum number -> {arr[posMax]}, minimum number -> {arr[posMin]}");
    Console.Write ($"Difference is {arr[posMax] - arr[posMin]}");
}


double[] arr_1 = MassNums(10);
ShowArray(arr_1);
SumMinMax (arr_1);
