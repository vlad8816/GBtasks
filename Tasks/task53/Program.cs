// //Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4

// 5 9 2 3

// 1 4 7 2
using static System.Console;
using MyLibArray;
Clear(); 

int [,] array = MyDoubleMethods.GenerateMnArray(3,4,1,10);
 WriteLine($"{String.Join(" ", array)}");
 MyDoubleMethods.PrintMnArray(array);
 int[] temp = new int[array.GetLength(1)];
 for (int i = 0; i < array.GetLength(1); i++)
    {
      temp[i] = array[0,i]; 
      array[0,i] = array[array.GetLength(0)-1,i];
      array[array.GetLength(0)-1,i] = temp[i]; 
    }
    WriteLine();
    MyDoubleMethods.PrintMnArray(array);

   


