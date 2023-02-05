// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

WriteLine(GetNumber(4,8));
int GetNumber(int start, int end )

{
    
    if (start == end  ) return end;
    else 
    { 
    return GetNumber(start,end-1)+end;
    }

}

