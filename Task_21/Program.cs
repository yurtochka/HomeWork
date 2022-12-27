// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();
 
WriteLine("Введите координаты Ax: ");
int.TryParse(ReadLine(), out int Ax);
WriteLine("Введите координаты Ay: ");
int.TryParse(ReadLine(), out int Ay);
WriteLine("Введите координаты Az: ");
int.TryParse(ReadLine(), out int Az);

WriteLine("Введите координаты Bx: ");
int.TryParse(ReadLine(), out int Bx);
WriteLine("Введите координаты By: ");
int.TryParse(ReadLine(), out int By);
WriteLine("Введите координаты Bz: ");
int.TryParse(ReadLine(), out int Bz);

double len_xyz = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
WriteLine($"{len_xyz:f2}");