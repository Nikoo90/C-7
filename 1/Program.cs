
double[,] ArrayTwoDimensional(int row, int col, int start, int end)
{

    double[,] arr = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(start, end + 1), 2);


        }
    }
    return arr;
}

void PrintArrayTwoDimensional(double[,] arr)
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
double[,] arr = ArrayTwoDimensional(6, 6, 100, 100);
PrintArrayTwoDimensional(arr);
Console.WriteLine();