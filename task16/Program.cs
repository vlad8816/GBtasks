//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

using static System.Console;
Clear();

WriteLine("Введите первое число ");
int number_one = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число ");
int number_two = Convert.ToInt32(ReadLine());
WriteLine(number_one == number_two*number_two? "Первое число это квадрат второго":"Первое число не является квадратом второго");
WriteLine(number_two == number_one*number_one? "Второе число это квадрат первого":"Второе число не является квадратом первого");