// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();

int a = AskUserForNumber(" Ввведите сторону треугольника a: ");
int b = AskUserForNumber(" Ввведите сторону треугольника b: ");
int c = AskUserForNumber(" Ввведите сторону треугольника c: ");

WriteLine(IsTriangle(a, b, c)? $"Треуголньик со сторонами {a}, {b}, {c} существует." : $"Треуголньик со сторонами {a}, {b}, {c} не существует.");

bool IsTriangle( int inA, int inB, int inC)
{
    if (inA + inB > inC && inA + inC > inB && inB + inC > inA) return true;
    return false;
}


int AskUserForNumber(string inPrompt)
{
    int resultNum = 0;
    string userInput = " ";
    while (!int.TryParse(userInput, out resultNum))
    {
        Console.Write(inPrompt);
        userInput = Console.ReadLine()!;
    }
    return resultNum;
}