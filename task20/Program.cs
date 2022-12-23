// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

using static System.Console;
Clear();

WriteLine("Введите x");
int x = Convert.ToInt32(ReadLine()!);
WriteLine("Введите y");
int y = Convert.ToInt32(ReadLine()!);
if(x > 0 && y > 0)
{
    WriteLine("I четверть");
}
if(x < 0 && y < 0)
{
    WriteLine("III четверть");
}
if(x > 0 && y < 0)
{
    WriteLine("IV четверть");
}
if(x < 0 && y > 0)
{
    WriteLine("II четверть");
}
if(x == 0 && y == 0)
{
    WriteLine("Начало координат");
}

