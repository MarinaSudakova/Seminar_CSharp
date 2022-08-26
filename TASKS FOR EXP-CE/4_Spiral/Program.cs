// Спирально заполнить двумерный массив:
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


int [,] MussNums (int row, int column)
{
    int [,] arr = new int[row, column];

    for (int i=0; i< row; i++)
    {
        for (int j=0; j< column; j++)
        {
            arr[i, j] = 0;
        }
    }
    return arr;
}

int []DirectionChange(int[]direction)
{
    if (direction[0]==0 && direction[1]==1)
    {
        direction[0]=1; 
        direction[1]=0;
    }
    else if (direction[0]==1 && direction[1]==0)
    {
        direction[0]=0; 
        direction[1]=-1;
    }
    else if (direction[0]==0 && direction[1]==-1)
        {
            direction[0]=-1; 
            direction[1]=0;
        }
    else if (direction[0]==-1 && direction[1]==0)
        {
            direction[0]=0; 
            direction[1]=1;
        }
    
    return direction;
}


int [,] SpiralFill2xArray(int[,] array)
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1);
    int i=0;
    int j=0;
    int iNew=0;
    int jNew=0;
    int[]direction ={0,1};
   
    for (int Index=1;Index<=row_size*column_size;Index++)
    {
        array[i,j]=Index;
        iNew=i+direction[0];
        jNew=j+direction[1];
        if(iNew>=0 && iNew<array.GetLength(0) && jNew>=0 && jNew<array.GetLength(1) && array[iNew,jNew]==0)
        {
            i+=direction[0];
            j+=direction[1];
        }
        else
        {
            DirectionChange(direction);
            i+=direction[0];
            j+=direction[1];
        }
    }
   return array;
}

Console.WriteLine ("Write a number of row: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine ("Write a number of column: ");
int column = int.Parse(Console.ReadLine());

int [,] newArr = MussNums(row, column);
SpiralFill2xArray (newArr);
PrintArray (newArr);
