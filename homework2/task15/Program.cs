// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
using static System.Console;
Clear();

WriteLine ("Введите цифру от 1 до 7 ");
int number = Convert.ToInt32(ReadLine());
WriteLine(number == 6 || number ==7?"Это выходной день":"Это будний день" );