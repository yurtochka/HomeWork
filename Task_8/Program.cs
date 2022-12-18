using static System.Console;

Clear();

WriteLine("Введите число: ");
int n = Convert.ToInt32(ReadLine());
int count = 1;
WriteLine(count); 

while (count <= n)
{
    if (count % 2 is 0)
    {
        WriteLine(count);       
    }
    count+=1;
}