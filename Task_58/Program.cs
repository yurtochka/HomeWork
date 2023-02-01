// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using static System.Console;
Clear();

WriteLine("Enter the size of the first array of the separated by a space: ");
string[] SizeArrFir = Console.ReadLine()!.Split(" ");
int a = int.Parse(SizeArrFir[0]);
int b = int.Parse(SizeArrFir[1]);

WriteLine("Enter the size of the second array of the separated by a space: ");
string[] SizeArrSec = Console.ReadLine()!.Split(" ");
int c = int.Parse(SizeArrSec[0]);
int d = int.Parse(SizeArrSec[1]);

WriteLine();

if (b == c) 
{
    int[,] ArrFir = GenerateRandomArray(a, b);
    int[,] ArrSec = GenerateRandomArray(c, d);

    WriteLine();
    PrintArray(ArrFir);
    WriteLine();
    PrintArray(ArrSec);
    WriteLine();

    int[,] PrArr = ProdArr(ArrFir, ArrSec);
    PrintArray(PrArr);
}
else 
    WriteLine($"The number of columns of the first matrix does not match the number of rows of the second matrix: {b} != {c}.");



//the product of two matrices
int[,] ProdArr(int[,] Arr1, int[,] Arr2)
{    
    int prod = 0;
    int[,] result = new int[Arr1.GetLength(0), Arr2.GetLength(1)];
    for (int i = 0; i < Arr1.GetLength(0); i++)
    {
        int xxx = Arr2.GetLength(1); 
        int z = 0;       
        int y = 0;
        while  (xxx > 0)
        {
            for (int j = 0; j < Arr2.GetLength(1); j++)
            {
                prod = prod + Arr1[i,j] * Arr2[j,y];
            }
            y++;
            xxx--;
            result[i,z] = prod;
            z++;
            prod = 0;
        }
    }
    return result;
}


//formation of a random array
int[,] GenerateRandomArray(int x, int y)
{
    int[,] RanArr = new int[x, y];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            RanArr[i, j] = rand.Next(1, 10);
        }
    }
    return RanArr;
}


//Print array
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j],3}");
        }
        WriteLine();
    }
}
