// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();

WriteLine("Введите два числа A и B: "); 
int A = Convert.ToInt32(ReadLine());
int B = Convert.ToInt32(ReadLine());
int x = 1;

if (B >= 0)
{
    for (int i = 1; i <= B; i++)
    {
        x = A * x;
    }
    WriteLine(x);    
}
else WriteLine("B - не натуральное число!");