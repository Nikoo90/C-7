
int[,] ArrayTwoDimensional(int row, int col, int start, int end)
{

    int[,] arr = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(start, end + 1);


        }
    }
    return arr;
}

void PrintArrayTwoDimensional(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

bool FindNumberInArray(int[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num) return true;
        }
    }
    return false;
}

int[,] arr = ArrayTwoDimensional(3, 4, 1, 100);

PrintArrayTwoDimensional(arr);

Console.WriteLine(FindNumberInArray(arr, 100));