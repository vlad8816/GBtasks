// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using static System.Console;
Clear();

Write("Введите число от 1 до ");
bool isParse= int.TryParse(ReadLine(),out int n);
if(!isParse)
{
    WriteLine("Не введено число");
    return;
}
for (int i=1;i <= n; i+=1)
{
    WriteLine($"Куб числа {i} равен {Math.Pow(i,3)}");
}