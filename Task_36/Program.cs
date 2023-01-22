// Напишите программу реализующую методы формирования массива, 
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();


Write("Enter the size array: ");
int LArr = Convert.ToInt32(ReadLine());

int[] RArr = RandomArray(LArr);
int sum = SumElemOdd(RArr);

WriteLine();
PrintArray(RArr);
Write($" -> {sum}");


//Counting the sum of elements of odd positions
int SumElemOdd(int[] array)
{
    int result = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            result = result + array[i]; 
    }
    return result;
}


//method formations random array
int[] RandomArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(-100, 100);
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