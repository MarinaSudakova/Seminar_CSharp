// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] ArrayMultiplication (int[,] arr1, int [,] arr2)
{
    int row = arr1.GetLength(0);
    int column = arr2.GetLength(1);
    
    int[,] newArr = new int [row, column];
    if (row != column)
        Console.WriteLine ("Error");

    else
    {
        for (int i=0; i< row; i++)
        {
            for (int j=0; j<column; j++)
            {
                for (int p = 0; p < column; p++)
                {
                    newArr[i, j] = newArr[i,j] + arr1[p,j] * arr2[i,p];
                }
            } 
        }
    }
    return newArr;
}


Console.Write("Enter the number of rows of first matrix: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns of first matrix: ");
int column1 = int.Parse(Console.ReadLine());

int[,] arr1 = MussNums (row1, column1, 1, 10);
PrintArray(arr1);
Console.WriteLine();

Console.Write("Enter the number of rows of second matrix: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns of second matrix: ");
int column2 = int.Parse(Console.ReadLine());
int[,] arr2 = MussNums (row2, column2, 1, 10);
PrintArray(arr2);

int[,] arr3 = ArrayMultiplication(arr1, arr2);
PrintArray(arr3);


