// Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и 
// вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76


using static System.Console;
Clear();
 
Write("Enter the size of the input array: ");
int x = Convert.ToInt32(ReadLine());

double[] result = RandomArray(x); 
double diff= MinMaxArray(result);

WriteLine();
PrintArray(result);
WriteLine($" -> {Math.Round(diff, 1)}");




//method search min and max in the array
double MinMaxArray(double[] arr)
{
    double difference;
    double result_min = arr[0];
    double result_max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > result_max) result_max = arr[i];        
        if (arr[i] < result_min) result_min = arr[i];
    }
    difference = result_max - result_min;
    return difference;
}

//method formations random array
double[] RandomArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(1, 100) + Math.Round(random.NextDouble(), 1);
    return array;
}

//method print array
void PrintArray(double[] arr_print)
{
    Write("[");
    for (int i = 0; i < arr_print.Length; i++)
    {
        {if (i == (arr_print.Length - 1))
            Write($"{arr_print[i]}]");
        else
            Write($"{arr_print[i]}; ");
        }
    }
}