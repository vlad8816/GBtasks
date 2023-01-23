// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да
using static System.Console;
Clear();

Write("ВВедите число: ");
int.TryParse(ReadLine(), out int number);

int [] array = {-1, -2, 0, 2, 1, 3, 4 };

// bool result = ArrayLookUp(array, number);
WriteLine(ArrayLookUp(array, number)? "да":"нет");

bool ArrayLookUp(int[] inArray, int num)
{
    foreach (var i in inArray)
    {
        if (num == i) return true;
    }
    return false;
}