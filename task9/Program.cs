﻿//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

using static System.Console;
Clear();
int number = new Random().Next(10, 100);// Команда "Next" минимальное значение входит в интервал, а максимальное нет, т.е. если нужен диапазон 1-5, нужно писать Next(1,6)
WriteLine(number);
WriteLine(number % 2 == 0?"Четное":"Нечетное");//Перевод - Выведи на строку остаток от деления number на 2 равняется 0? Если да напиши "Четное" иначе "Нечетное"
//int a1 = number/10;//убирает младший разряд
//int a2 = number%10;//вернет младший разряд от деление
//int max = a1 > a2? a1:a2;//тернарный оператор(оператор присваивания)
                          //после знака '=' стоит сравнение,а значение истины ставится после знака '?'
                        // если а1 > а2 тогда (?) присвоить а1 иначе(:) присвоить а2
WriteLine(number/10 > number%10? number/10:number%10);//в скобках стояло 'max', но так как есть тернарный оператор, мы избавились от строчки 'int max'
// if(a1 > a2)
// {
//     WriteLine(a1);
// }
// else
// {
//     WriteLine(a2);
// }