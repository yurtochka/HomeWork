// Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();

WriteLine("Enter two values n and m separated by a space: ");
string[] values = Console.ReadLine()!.Split(' ');
int N = int.Parse(values[0]);
int M = int.Parse(values[1]);

WriteLine();
WriteLine($"m = {M}, n = {N} -> {FuncAkker(N, M)}");

int FuncAkker(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if (n != 0 && m == 0)
            return FuncAkker(n - 1, 1);
        else
            return FuncAkker(n - 1, FuncAkker(n, m - 1));
}