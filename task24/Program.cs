// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

using static System.Console;
Clear();

Write("Введите число от 1 до числа: ");
bool isParse = int.TryParse(ReadLine(), out int N);
if(!isParse)
{
    WriteLine("Не введено число");
    return;
}
for (int i = 1; i <= N; i+=1)
{
    WriteLine($"Квадрат числа {i} - {Math.Pow(i,2)}");
}
