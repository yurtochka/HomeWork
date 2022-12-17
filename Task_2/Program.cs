using static System.Console; 

Clear();

WriteLine("Введите два часла: ");
int a = int.Parse(ReadLine());
int b = int.Parse(ReadLine());

if (a > b)
    WriteLine($"Первое число ({a}) больше второго ({b})");
else
    WriteLine($"Второе число ({b}) больше первого ({a})"); 
