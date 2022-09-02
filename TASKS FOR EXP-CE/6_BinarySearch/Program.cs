// Бинарный поиск поиск числа в массиве

int[] FillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(1, 101);
    }
    return array;
}

int[] SortArray (int[] array)
{
    int size = array.Length;
    for (int j = 0; j < size; j++)
    {
        for (int i = 0; i < size-1-j; i++)
        {
            if (array[i] > array[i + 1])
                (array[i],array[i+1]) = (array[i+1],array[i]);
        }
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]} ");
    }
}


// int BinarySearch (int[] array, int find)
// {
//     int low = 0;
//     int high = array.Length;
//     int middle = array.Length / 2;
//     int guess = 0;

//     while (low < high-1)
//     {
//         guess = array[middle];

//         if (guess == find)
//             return (middle + 1);

//         if (guess == find)
//             return (middle + 1);

//         else if (guess > find)
//         {
//             high = middle - 1;
//             middle = ((high -1 - low) / 2);
//         }

//         else
//         {
//             low = middle + 1; 
//             middle = ((high -1 - low) / 2) + middle;
//         }
//     }
//     Console.WriteLine("is not found");
//     return 0;
// }

int BinarySearch (int[] array, int find)
{
    int low = 0;
    int high = array.Length-1;
    int middle = array.Length / 2;

    while (low < high)
    {
        if (array[middle] == find)
            return (middle + 1);

        else if (array[middle+1] == find)
            return (middle + 2);

        else if (array[middle-1] == find)
            return (middle);

        else if (array[middle] > find)
        {
            high = middle - 1;
            middle = ((high - low) / 2);
        }

        else
        {
            low = middle + 1; 
            middle = ((high - low) / 2) + middle;
        }
    }
    Console.WriteLine("is not found");
    return 0;
}

int[] newArr = FillArray(15);
PrintArray(newArr);
SortArray(newArr);
Console.WriteLine();
PrintArray(newArr);

Console.WriteLine ("Write a wanted number: ");
int a = int.Parse(Console.ReadLine());

Console.Write ($"Position of wanted number {BinarySearch(newArr, a)} ");


