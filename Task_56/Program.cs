// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

WriteLine("Enter the size of the separated by a space: ");
string[] SizeArr = Console.ReadLine()!.Split(" ");
int a = int.Parse(SizeArr[0]);
int b = int.Parse(SizeArr[1]);

WriteLine();

if (a != b && a > 1 && b > 1)
{
    int[,] GenArr = GenerateRandomArray(a, b);
    int[] sum = SumRowsArray(GenArr);

    PrintArray(GenArr, sum);
    WriteLine();
    WriteLine($"Smaller sum of elements: {MinSumRowsArray(sum) + 1} string");
}
else 
    WriteLine("Two-dimensional array is not rectangular.");

//search for the min sum of numbers in array string
int  MinSumRowsArray(int[] MinArr)
{
    int result = MinArr[0];
    int MinStr = 0;
    for (int i = 0; i < MinArr.Length; i++)
    {
        if (result >= MinArr[i])  
        {
            result = MinArr[i];
            MinStr = i;
        }
    }
    return MinStr;
}


//the sum of the numbers of all the rows in the array
int[] SumRowsArray(int[,] array)
{
    int sum = 0;
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
        sum = 0;
    }
    return result;
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
void PrintArray(int[,] arr, int[] ArrSum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j],3}");
        }
        Write($"  -> {ArrSum[i],3}");
        WriteLine();
    }
}
