// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using static System.Console;
Clear();

WriteLine("Введите номер дня недели: ");
int DayWeek = Convert.ToInt32(ReadLine());

if (DayWeek > 0 && DayWeek < 8)
{
    if (DayWeek > 5 && DayWeek < 8) 
    {
        WriteLine("Выходной день! Ура!");
    }
    else
    {
        WriteLine("Будний день.");
    }
}
else
    WriteLine("Вы ввели не номер дня недели.");