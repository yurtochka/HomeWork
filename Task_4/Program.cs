using static System.Console;

Clear();

WriteLine("Введите три числа: ");
int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());
int c = Convert.ToInt32(ReadLine());

if (a > b && a > c)
    WriteLine($"MAX = {a}");
else 
    if (b > a && b > c)
        WriteLine($"MAX = {b}");
    else
        if (c > a && c > b)
            WriteLine($"MAX = {c}");
        