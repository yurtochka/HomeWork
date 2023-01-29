// Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Console;
Clear();


Random m = new Random();
Random n = new Random();
int x = m.Next(1, 10);
int y = n.Next(1, 10);

int[,] GenArr = GenerateRandomArray(x,y);

WriteLine($"Array: ({x}; {y})");

WriteLine();
PrintArray(GenArr);
WriteLine();

double[] AvrArr = AverageArray(GenArr);

PrintArrayAvr(AvrArr);


//search for the arithmetic mean of each column
double[] AverageArray(int[,] array)
{   
    double[] avr = new double[array.GetLength(1)];
    double xxx = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            xxx = xxx + array[j,i];
        }
        avr[i] = Math.Round(xxx / array.GetLength(0), 1);
        xxx = 0;
    }
    return avr;
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
            Write($"{arr[i,j], 6}");
        }
        WriteLine();
    }
}

//method print array avr
void PrintArrayAvr(double[] arr_print)
{
    for (int i = 0; i < arr_print.Length; i++)
    {
        Write($"  {arr_print[i], 4}");
    }
}