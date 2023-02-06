// Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using static System.Console;
Clear();

WriteLine("Enter values M and N to space: ");
string[] val = ReadLine()!.Split(" ");
int m = int.Parse(val[0]);
int n = int.Parse(val[1]);

int res = PrintNumbers(m, n);
WriteLine();
WriteLine($"M = {m}; N = {n} -> {res}");

int PrintNumbers(int M, int N)
{
    return N == M ? N : M + PrintNumbers(M + 1, N);
}

