// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


void PrintArray (int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i=0; i< row_size; i++)
    {
        for (int j=0; j< column_size; j++)
        {
            Console.Write ($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int [,] MussNums (int row, int column, int from, int to)
{
    int [,] arr = new int[row, column];

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            arr[i, j] = new Random().Next (from,to);
        }
    }
    return arr;
}

int[] MinSearch (int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int min = array[0,0];
    int [] new_arr = new int [2];

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            if (min > array[i,j])
            {
                min = array[i,j];
                new_arr [0] = i;
                new_arr [1] = j;
            }
        }
    }
    return new_arr;
}


void DeleteMinimum (int[,] arr, int[] arr_2)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            if (arr_2[0] == i || arr_2[1] == j)
                continue;
            else
                Console.Write ($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MussNums(row, column, 1, 11);
PrintArray(arr_1);


int[] arr_2 = MinSearch(arr_1);
DeleteMinimum(arr_1, arr_2);


