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
int i = 1;
while(i <= N)
{
    WriteLine($"Квадрат числа {i} - {Math.Pow(i,2)}");
    i+=1;
}