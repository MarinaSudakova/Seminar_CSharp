//Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

int [,] FillArray (int row, int column, int from, int to)
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


void PrintArray (int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i=0; i< row_size; i++)
    {
        for (int j=0; j< column_size; j++)
        {
            Console.Write ($" {arr[i, j], 3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

string FindNum (int[,] arr)
{
    Console.WriteLine ("Enter a row of wanted element: ");
    int find_row = int.Parse(Console.ReadLine());

    Console.WriteLine ("Enter a column of wanted element: ");
    int find_column = int.Parse(Console.ReadLine());

    if (arr.GetLength(0) < find_row || arr.GetLength(1) < find_column)
    {
        return "Position is not in array:(";
    }
    else 
        return $" Element is {arr[find_row-1, find_column-1]} ";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 1, 31);
PrintArray(arr_1);

Console.WriteLine (FindNum(arr_1));