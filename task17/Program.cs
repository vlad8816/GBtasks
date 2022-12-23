//  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

using static System.Console;
Clear();

Write("Введите номер четверти:");
bool isParse = int.TryParse(ReadLine(), out int i);// метод "TryParse" позволяет проверить можно - ли преобразовать то, 
                                                   // что внутрь положили к типу данных, который указан первым (int)
                                                   // если это можно сделать, тогда помести (out) это значение в новую переменную с указанным именем (int i)
                                                   // TryParse возвращает True или False
if(!isParse)// если невозможно преобразовать наши данные, к тому типу, что мы прописали, то
{
    WriteLine("Введено не число");
    return;
}

 switch(i)
 {
    case 1:
    {
        WriteLine("x > 0, y > 0");
        break;
    }
    case 2:
    {
        WriteLine("x < 0, y > 0");
        break;
    }
    case 3:
    {
        WriteLine("x < 0, y < 0");
        break;
    }
    case 4:
    {
        WriteLine("x > 0, y <0");
        break;
    }
    default:
    {
        WriteLine("Нет такой четверти");
        break;
    }
 }
// if(i < 1 || i > 4)
// {
//     WriteLine("Ошибка");
//     return;

// }
// if (i == 1)
// {
//     WriteLine("x > 0, y > 0");
// }
// if (i == 2)
// {
//     WriteLine("x < 0, y > 0");
// }
// if (i == 3)
// {
//     WriteLine("x < 0, y < 0");
// }
// if (i == 4)
// {
//     WriteLine("x > 0, y <0");
// }