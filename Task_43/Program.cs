// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. (43 task)

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

WriteLine("Enter two values b1 and k1 separated by a space for the one equation: ");
string[] values1 = Console.ReadLine()!.Split(' ');
double b1 = int.Parse(values1[0]);
double k1 = int.Parse(values1[1]);

WriteLine("Enter two values b2 and k2 separated by a space for the seconde equation: ");
string[] values2 = Console.ReadLine()!.Split(' ');
double b2 = int.Parse(values2[0]);
double k2 = int.Parse(values2[1]);

WriteLine();
string result = SearchPointInter(b1, k1, b2, k2);
Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {result}");



// finding the intersection point of two straight lines
string SearchPointInter(double a1, double c1, double a2, double c2)
{
    double FirstEquation = (a2 - a1) / (c1 - c2);
    double SecondeEquation = (a1 * c2 - a2 * c1) / (c2 - c1);

    string res = "(" + FirstEquation + ";" + SecondeEquation + ")";
    return res;
}