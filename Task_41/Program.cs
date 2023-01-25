// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. (41 Task)

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Enter the numbers separated by a space: ");
int[] StrNum = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

int count = CountNum(StrNum);
WriteLine();
Write($"{String.Join(", ",StrNum)}");
Write($" -> {count}");



// counting method numbers greater than sero
int  CountNum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}