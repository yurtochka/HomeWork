// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9


using static System.Console;
Clear();

Random m = new Random();
Random n = new Random();
int x = m.Next(1, 10);
int y = n.Next(1, 10);

int[,] array = GenerateRandomArray(x, y);

WriteLine($"{x-1};{y-1}");

WriteLine();
PrintArray(array);
WriteLine();

WriteLine("Enter the array positions separated by a semicolon: ");
string[] PosArr = ReadLine()!.Split(";", StringSplitOptions.RemoveEmptyEntries);  //enter position element array

int x1 = int.Parse(PosArr[0]);
int y1 = int.Parse(PosArr[1]);

//returning the value of an element from an array or indication its absence
WriteLine((x1 <= x-1 && y1 <= y-1) ? $"-> {array[x1, y1]}" : "-> This element is not in the array.");  
    
  

//formation of a random array
int[,] GenerateRandomArray(int a, int b)
{
    int[,] RanArr = new int[a, b];
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            RanArr[i, j] = rand.Next(0, 10);
        }
    }
    return RanArr;
}


//print array
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i,j], 3}");
        }
        WriteLine();
    }
}