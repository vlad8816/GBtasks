//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

using static System.Console;
Clear();

int number = new Random().Next(100,1000);
WriteLine(number);
int number1 = number/100;
int number2 = number % 10;
Write(number1);
Write(number2);