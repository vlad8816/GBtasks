//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

using static System.Console;
Clear();

WriteLine("Точка А ---> Введите координаты х1");
bool isParse1 = int.TryParse(ReadLine(),out int ax);

if(!isParse1)
{
    WriteLine("Не введены координаты");
    return;
}
WriteLine("Точка А ---> Введите координаты у1");
bool isParse2 = int.TryParse(ReadLine(),out int ay);

if(!isParse2)
{
    WriteLine("Не введены координаты");
    return;
}
WriteLine("Точка В ---> Введите координаты х2");
bool isParse3 = int.TryParse(ReadLine(),out int bx);

if(!isParse3)
{
    WriteLine("Не введены координаты");
    return;
}
WriteLine("Точка В ---> Введите координаты у2");
bool isParse4 = int.TryParse(ReadLine(),out int by);

if(!isParse4)
{
    WriteLine("Не введены координаты");
    return;
}
double length = Math.Sqrt(Math.Pow((ax-bx),2)+ Math.Pow((ay-by),2));// Math.Sqrt - корень квадратный, Math.Pow - Возвращает указанное число(ax-bx), возведенное в указанную степень(2).
WriteLine($"{length:f2}");// f2 это округление (2) количество знаков после запятой показывает
