﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
using static System.Console;
Clear();
WriteLine("Введите число ");
int a =int.Parse(ReadLine()!);
if (a%2 == 0)Write("Четное");
else Write("Нечетное"); 
