// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных. Значения элементов массива 0..9

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

// cделала частотный словарь для двух элементов
void FindElement (int[,] arr)
{
    Console.WriteLine ("Write first element you want to find: ");
    int firstElement = int.Parse(Console.ReadLine());

    Console.WriteLine ("Write second element you want to find: ");
    int secondElement = int.Parse(Console.ReadLine());

    int countFirstElement = 0;
    int countSecondElement = 0;
    
    foreach (int num in arr)
        {
            if (num == firstElement)
                countFirstElement++;

            if (num == secondElement)
                countSecondElement++;
        }
    Console.WriteLine ($" First element is finded {countFirstElement} times");
    Console.WriteLine ($" Secont element is finded {countSecondElement} times,");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MussNums(row, column, 0, 10);
PrintArray(arr_1);

Console.WriteLine();
FindElement(arr_1);
