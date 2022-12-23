// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using static System.Console;
Clear();

WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(ReadLine());
int number_two = number % 100;
int number_three = number_two/10;
WriteLine(number_three);