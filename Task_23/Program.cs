// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using static System.Console;
Clear(); 

WriteLine("Введите число: ");
int.TryParse(ReadLine(), out int n); 

while (n > 0)
{
    WriteLine(Math.Pow(n, 3));
    n--;
}
