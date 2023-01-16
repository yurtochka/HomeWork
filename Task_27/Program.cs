// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

Write("Input number: ");
int number = int.Parse(ReadLine()!);

int sum = SumNumber(number);
WriteLine(sum);




int SumNumber(int A)
{
    int result = 0;
    for (int i = 0; i <= A; i++)
    {
        result = result + (A % 10);
        A = A / 10;
    }
    return result;
}