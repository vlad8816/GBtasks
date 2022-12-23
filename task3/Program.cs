//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// using static System.Console;
// Clear();
// // WriteLine("Введите число ");
// // int number = Convert.ToInt32(ReadLine());

// // WriteLine();
using static System.Console;
Write("Input number: ");
int number = int.Parse(ReadLine()!);

int start = -number;
while (start < number)
{
    Write($" {start},");
    start +=1;
}
WriteLine($" {start}");