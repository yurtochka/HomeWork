using static System.Console;

Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int rem = (a % 2);

if (rem is 0)
    WriteLine("Число является четным!");
else
    WriteLine($"Число не четное.");