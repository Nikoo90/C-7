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

double[] AverageColumnArray(int[,] arr)
{

    double[] result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[j] += Math.Round(Convert.ToDouble(arr[i, j]) / arr.GetLength(0), 2);
        }

    }

    return result;
}

int[,] arr = ArrayTwoDimensional(3, 4, 1, 100);
PrintArrayTwoDimensional(arr);
Console.WriteLine();
double[] arr1 = AverageColumnArray(arr);
for (int i = 0; i < arr1.Length; i++) Console.Write($"{i + 1}){arr1[i]}  ");
Console.WriteLine();