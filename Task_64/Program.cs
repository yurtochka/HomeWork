// Напишите программу, которая реализует рекурсивный метод вывода всех натуральных чисел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();

WriteLine("Enter N: ");
int N = int.Parse(ReadLine()!);

WriteLine();
WriteLine($"N = {N} -> {ArrayNatNum(N)}");

string ArrayNatNum(int n)
{
    if (n == 1)
        return n.ToString();
    else
        return $"{n}, {ArrayNatNum(n - 1)}";        
}