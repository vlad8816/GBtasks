﻿// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

using static System.Console;

Write("Введите число: ");
int day = Convert. ToInt32(ReadLine());

if (day <= 7 && day >= 1)
{
    if (day == 1)
    {
        Write("Понедельник");
    }
   if (day == 2)
    {
        Write("Вторник");
    }
    if (day == 3)
    {
        Write("Среда");
    }
    if (day == 4)
    {
        Write("Четверг");
    }
    if (day == 5)
    {
        Write("Пятница");
    }
    if (day == 6)
    {
        Write("Суббота");
    }
    if (day == 7)
    {
        Write("Воскресенье");
    }
}
else
{
        Write("Данного дня недели не существует");
}

