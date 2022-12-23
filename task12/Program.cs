//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

using static System.Console;
Clear();
WriteLine("Введите первое число ");
int first_number = int.Parse(ReadLine()!);
WriteLine("Введите второе число ");
int second_number = int.Parse(ReadLine()!);
int ost = first_number % second_number;
if(first_number%second_number == 0)
{
    WriteLine("Кратно");

}
else
{
WriteLine($"Не кратно и остаток {ost}");
}