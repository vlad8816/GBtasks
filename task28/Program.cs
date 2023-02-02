// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5
using static System.Console;
Clear();

Write("Input number: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);
WriteLine($"Number consists of {sum} numbers");

int GetSum(int A)
{
    int result = 0;
    while(number > 0 )
    {
        number = number/10;
        result++;
    } 
    return result;
}