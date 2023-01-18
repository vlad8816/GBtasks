//  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

using static System.Console;
Clear();

WriteLine("Input number: ");
int number = int.Parse(ReadLine()!);

int multi = GetMulti(number);
WriteLine($"Multiplication 1..N = {multi} ");


int GetMulti (int A)
{
    int result = 1;
    while(A > 0)
    {
       result*=A;
        A--;
    }
    return result;
}
