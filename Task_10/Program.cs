//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();

WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(ReadLine());
int a = (int)Math.Log10(n) + 1;

if (a == 3)
    WriteLine($"Вторая цифра числа {n} -> {n / 10 % 10}");
else
    WriteLine("Не трехзначное число.");


