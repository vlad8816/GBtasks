// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;
Clear();

int [,] array = GenerateMNarray(4,4,1,10);

PrintMnArray(array);
Minrow(array);

int [,] GenerateMNarray(int sizeM,int sizeN, int BeginArr, int EndArr)
{
    if (sizeM == 0 || sizeN == 0)
    {
        WriteLine("Size can't be zero");
        Environment.Exit(0);
    }
    int[,] result = new int[sizeM, sizeN];
    Random rnd = new Random();
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            result[i,j] = rnd.Next(BeginArr,EndArr);
        }
        
    } 
    return result;
}

void PrintMnArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j], 3}");
        }
         WriteLine();
    }
   
}
void Minrow (int[,] inArray)
{
    int index = 0; 
    int minsum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i,j];
        }
        if (i == 0)
        {
            minsum = sum;
            index = 1;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i+1;
        }
    }
    WriteLine($"Номер строки с наименьшей суммой элементов: {index} строка.");
}