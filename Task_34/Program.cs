// Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, 
// и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


using static System.Console;
Clear();


Write("Input size array: ");
int n = int.Parse(ReadLine()!);

int[] ArRes = RandomArray(n);
int amount = ThreeDigitArray(ArRes);

WriteLine();
PrintArray(ArRes);
Write($" -> {amount}");


// Search even numbers in the array
int ThreeDigitArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            result++;
    }
    return result;
}


//method formations random a three-digit array
int[] RandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(1000);
    return array;
}


//method print array
void PrintArray(int[] arr_print)
{
    Write("[");
    for (int i = 0; i < arr_print.Length; i++)
    {
        {if (i == (arr_print.Length - 1))
            Write($"{arr_print[i]}]");
        else
            Write($"{arr_print[i]}, ");
        }
    }
}