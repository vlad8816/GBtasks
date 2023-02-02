// Задача 32: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

using static System.Console;
Clear();
Write("Введите размер массива, мин и мах через пробел:");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);//Split - позволяет разбить строку на подстроки указанным разделителем(" " - пробел)

int[] array = GetArray(int.Parse(parameters[0]),int.Parse(parameters[1]),int.Parse(parameters[2]));
PrintArray(array);


WriteLine();
int negativeSum = 0;
int positiveSum = 0;

foreach(var a in array)
{
    negativeSum += a < 0 ? a : 0;
    positiveSum += a > 0 ? a : 0; 
}

WriteLine($"{negativeSum}  {positiveSum}");



int[] GetArray(int size, int minValue,int maxValue)// метод GetArray, который создает массив указанного размера(int size(аргумент, который передается в массив)) 
                                                //в указанном диапазоне(int minValue, int MaxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
     Write($"{inArray[inArray.Length - 1]}],");
}


// WriteLine("Введите координаты А через пробел: ");
// Point A = GetPointFromString(ReadLine()!);

// WriteLine("Введите координаты B через пробел: ");
// Point B = GetPointFromString(ReadLine()!);

// WriteLine("Введите координаты C через пробел: ");
// Point C = GetPointFromString(ReadLine()!);

// double delta = Math.Sqrt(Math.Pow(A.X - B.X,2)+ Math.Pow(A.Y - B.Y,2)+ Math.Pow(A.Z - B.Z,2));
// WriteLine(delta);
// Point GetPointFromString(string inStr)
// {
//     string par = inStr.Split(" ",StringSplitOptions.RemoveEmptyEntries);
//     res.X = int.Parse(par[0]);
//     res.Y = int.Parse(par[1]);
//     res.Z = int.Parse(par[2]);
//     return res;
// }
// struct Point
// {
//     public int X;
//     public int Y;
//     public int Z;
// }