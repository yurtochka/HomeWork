// Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();
 
int[] ArRan = ArrRandom();
PrintArray(ArRan);






int[] ArrRandom()
{
    int[] res_arr = new int[8];
    for (int i = 0; i < res_arr.Length; i++)
    {
        res_arr[i] = new Random().Next(1,100);
    }
    return res_arr;
}

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