// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;
Clear();

WriteLine("Введите число: ");
int n = Convert.ToInt32(ReadLine());

int Count = (int)Math.Log10(n) + 1;
int x = 0;
int a = n;

if (Count > 2)
{
    while (Count > 2)
    {
        x = a % 10;
        a /= 10;
        Count--;
    }
    WriteLine($"Третья цифра числа {n} -> {x}");
}
else
{
    WriteLine("В числе нет третьей цифры.");
}
