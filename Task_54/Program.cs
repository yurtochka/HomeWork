// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();

int a = 5;
int b = 10;

int[,] GenArr = GenerateRandomArray(a, b);

// WriteLine($"Array: ({x}; {y})");

WriteLine();
PrintArray(GenArr);
WriteLine();

int[,] AvrArr = AverageArray(GenArr);

PrintArray(AvrArr);


//sort the array in descending order
int[,] AverageArray(int[,] array) 
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int b = array.GetLength(1);
        while (b > 0)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i, j] < array[i, j + 1]) 
                {
                    int xxx = array[i, j];
                    array[i, j] = array[i, j+1];
                    array[i, j+1] = xxx;
                }
            }
            b--;
        }
    }
    return array;
}


//formation of a random array
int[,] GenerateRandomArray(int a, int b)
{
    int[,] RanArr = new int[a, b];
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
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

