// //**Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12
using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);
WriteLine(SumDiagonal(array));




int[,] GetMatrixArray(int rows, int columns)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rand.Next(10);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],4} ");  // вывод в 3 символа
        }
        WriteLine();
    }
    WriteLine();
}

int SumDiagonal (int[,] inArray){
    int result = 0;
    int size = inArray.GetLength(1) < inArray.GetLength(0) ? inArray.GetLength(1) : inArray.GetLength(0);
    for (int i = 0; i < size; i++)
    {
       result += inArray[i, i];
    }

    return result;
}
