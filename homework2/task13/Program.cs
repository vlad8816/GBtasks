// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

using static System.Console;
Clear();

WriteLine("Введите число - ");
int number = Convert.ToInt32(ReadLine());
int n = number;

while (Math.Abs(n) > 999)
{
    n /= 10;
}
    
WriteLine(Math.Abs(number) < 100? "Третьей цифры нет": $"{n % 10}");  