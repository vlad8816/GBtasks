// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
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
WriteLine("Точка А ---> Введите координаты z1");
bool isParse3 = int.TryParse(ReadLine(),out int az);

if(!isParse3)
{
    WriteLine("Не введены координаты");
    return;
}
WriteLine("Точка В ---> Введите координаты х2");
bool isParse4 = int.TryParse(ReadLine(),out int bx);

if(!isParse4)
{
    WriteLine("Не введены координаты");
    return;
}
WriteLine("Точка В ---> Введите координаты у2");
bool isParse5 = int.TryParse(ReadLine(),out int by);

if(!isParse5)
{
    WriteLine("Не введены координаты");
    return;
}
WriteLine("Точка B ---> Введите координаты z2");
bool isParse6 = int.TryParse(ReadLine(),out int bz);

if(!isParse6)
{
    WriteLine("Не введены координаты");
    return;
}
// WriteLine("Точка C ---> Введите координаты x3");
// bool isParse7 = int.TryParse(ReadLine(),out int cx);

// if(!isParse7)
// {
//     WriteLine("Не введены координаты");
//     return;
// }
// WriteLine("Точка C ---> Введите координаты y3");
// bool isParse8 = int.TryParse(ReadLine(),out int cy);

// if(!isParse8)
// {
//     WriteLine("Не введены координаты");
//     return;
// }
// WriteLine("Точка C ---> Введите координаты z3");
// bool isParse9 = int.TryParse(ReadLine(),out int cz);

// if(!isParse9)
// {
//     WriteLine("Не введены координаты");
//     return;
// }
double length = Math.Sqrt(Math.Pow((ax-bx),2)+ Math.Pow((ay-by),2)+ Math.Pow((az-bz),2));
WriteLine($"{length:f2}");
//// нужно продолжить, как в задаче 22, ушел спать