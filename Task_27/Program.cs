// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

Write("Input number: ");
int number = int.Parse(ReadLine()!);
WriteLine();
WriteLine($"The sum of the digits of the number {number} = {SumNumber(number)}");




int SumNumber(int A)
{
    int result = 0;
    A = Math.Abs(A);
    while (A > 0)
    {
        result = result + (A % 10);
        A = A / 10;
    }   
    return result;
}