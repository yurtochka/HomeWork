// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

WriteLine("Enter the size of the separated by a space: ");
string[] SizeArr = Console.ReadLine()!.Split(" ");
int a = int.Parse(SizeArr[0]);
int b = int.Parse(SizeArr[1]);
int c = int.Parse(SizeArr[2]);

int[,,] Array = ThreeArray(a, b, c);

WriteLine();
PrintArray(Array);

//formation tree-dimensional array
int[,,] ThreeArray(int x, int y, int z)
{
    Random random = new Random();
    var num = Enumerable.Range(10, 89).ToList(); //generating a range of numbers from 10 to 99
    int[,,] arr = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int ran = random.Next(0, num.Count);
                int number = num[ran]; //take a random number from the list
                num.RemoveAt(ran); //deleted the used number

                arr[i, j, k] = number;
            }
        }
    }
    return arr;
}


//Print array
void PrintArray(int[,,] TArr)
{
    for (int i = 0; i < TArr.GetLength(0); i++)
    {
        for (int j = 0; j < TArr.GetLength(1); j++)
        {
            for (int k = 0; k < TArr.GetLength(2); k++)
            {
                Write($"{TArr[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}