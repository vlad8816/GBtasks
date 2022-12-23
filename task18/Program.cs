// // Напишите программу, которая будет выдавать название дня недели по заданному номеру.

using static System.Console;
Clear();

WriteLine("Введите число 1-7");
int number = Convert.ToInt32(ReadLine()!);

switch(number)
{
    case 1:
    {
    WriteLine("Понедельник");
    break;
    }
    case 2:
    {
        WriteLine("Вторник");
        break;
    }
    case 3:
    {
        WriteLine("Среда");
        break;
    }
    case 4:
    {
        WriteLine("Четверг");
        break;
    }
    case 5:
    {
        WriteLine("Пятница");
        break;
    }
    case 6:
    {
        WriteLine("Суббота");
        break;
    }
    case 7:
    {
        WriteLine("Воскресенье");
        break;
    }
    default:
    {
        WriteLine("Нет такого дня");
        break;
    }
}
