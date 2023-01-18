// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

using static System.Console;
Clear();

WriteLine("Input number ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);
WriteLine($"Sum = {sum}");

int GetSum(int A)
{
    int result = 0;
    while(A > 1)
    {
        result = result +A%10;
        A=A/10;
    }
    return result;
}