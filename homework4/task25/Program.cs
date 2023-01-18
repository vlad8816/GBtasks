// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

using static System.Console;
Clear();

WriteLine("Input number A");
int numberA = int.Parse(ReadLine()!);
WriteLine("Input number B");
int numberB = int.Parse(ReadLine()!);

int degree = GetDegree(numberA);
WriteLine($"Degree equals = {degree}");

int GetDegree(int A)
{
    int result = 1;
    while(numberB> 0)
    {
        result*=numberA;
        numberB--; 
    }
    return result;
}