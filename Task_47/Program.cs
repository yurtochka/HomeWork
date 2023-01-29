//  Напишите программу реализующую метод, который возвращает массив размером m x n, заполненный случайными вещественными числами.(Task_47)

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
Clear();

WriteLine("Input size matrix:");
Write("  m = ");
int m = Convert.ToInt32(ReadLine());
Write("  n = ");
int n = Convert.ToInt32(ReadLine());

WriteLine();
double[,] array = GetMatrixRandom(m, n);
PrintMatrix(array);



//formation of a random array
double[,] GetMatrixRandom(int x, int y)
{
    double[,] DoubleArray = new double[x, y];
    Random random = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
           DoubleArray[i, j] = random.Next(-10, 10) + Math.Round(random.NextDouble(), 1);
        }
    }
    return DoubleArray;
}

//printing the result of the generated array
void PrintMatrix(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 5} ");  
        }
        WriteLine();
    }
}