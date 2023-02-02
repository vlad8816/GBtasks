namespace MyLibArray;
using static System.Console;
public class MyLineMethods
{
///<summary>
/// Метод 1 одномерный массив 
///</summary>
    public static int[] GetLineArray(int size)
    {
        if (size == 0)
      {
        WriteLine("Size can't be zero");
        Environment.Exit(0);
      }
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next();
        }
        return result;
    }
///<summary>
/// Метод 2 одномерный массив с максимумом 
///</summary>
    public static int[] GetLineArray(int size, int maxValue)
    {
          if (size == 0)
      {
        WriteLine("Size can't be zero");
        Environment.Exit(0);
      }
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(maxValue + 1);
        }
        return result;
    }
///<summary>
/// Метод 3 одномерный массив в диапазоне
///</summary>
    public static int[] GetLineArray(int size, int minValue, int maxValue)
    {
          if (size == 0)
      {
        WriteLine("Size can't be zero");
        Environment.Exit(0);
      }
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(minValue, maxValue);
        }
        return result;
    }
///<summary>
/// Метод 4 Вывод массива 
///</summary>
public static void PrintArray (int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        WriteLine($"{inArray[i]}");
    }
    WriteLine();
}
 
}
public class MyDoubleMethods
{
///<summary>
/// Метод 1 Генерирует рандомный двумерный массив с вещественными числами 
///</summary>
public static double [,] GenerateDoubleMnArray(int sizeM, int sizeN, double BeginArr, double EndArr, int accuracy)
{
    if (sizeM == 0 || sizeN == 0)
    {
        WriteLine("Size can't be zero");
        Environment.Exit(0);
    }
    double [,] result = new double [sizeM, sizeN];
    Random rnd = new Random();
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            result[i,j] = Math.Round((BeginArr + rnd.NextDouble() * (EndArr - BeginArr)), accuracy);
        }    
    }
    return result;
}
///<summary>
/// Метод 2 print double[,] array.
///</summary>
public static void PrintDoubleMnArray (double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($" { inArray[i,j] }");
        }
        WriteLine();
    }
} 
///<summary>
/// Метод 3 Генерирует рандомный двумерный массив 
///</summary>
public static int [,] GenerateMnArray(int sizeM, int sizeN, int BeginArr, int EndArr)
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
///<summary>
/// Метод 4 print int[,] array.
///</summary>
public static void PrintMnArray (int[,] inArray)
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



}







