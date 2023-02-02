// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static System.Console;
Clear();

int [,] array = GenerateMnArray(3,5,0,99);
PrintMnArray(array);
WriteLine();
PrintMnArray(ChangeMatrix(array));



int [,] GenerateMnArray(int sizeM, int sizeN, int BeginArr, int EndArr)
{
    if (sizeM == 0 || sizeN == 0)
    {
        WriteLine("Size can't be zero");
        Environment.Exit(0);
    }
    int [,] result = new int [sizeM, sizeN];
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
 void PrintMnArray (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($" { inArray[i,j], 3 }");
        }
        WriteLine();
    }
} 

int[,] ChangeMatrix(int[,] inArray)
{
    int [,] ChangeMatrix = new int[inArray.GetLength(0),inArray.GetLength(1)];
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                for (int k = 0; k < inArray.GetLength(1)-1; k++)
                {
                    if (inArray[i,k] < inArray[i,k+1])
                    {
                        int t = inArray[i,k];
                        inArray[i,k] = inArray[i,k+1];
                        inArray[i,k+1] = t;
                    }
                }
            }
        }
        return inArray;
    }

}
