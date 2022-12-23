// // Напишите программу, которая будет выдавать название дня недели по заданному номеру.

using static System.Console;
Clear();

WriteLine("Введите число 1-7");
int number = Convert.ToInt32(ReadLine()!);

switch(number)
{
    case 1:
    {
    WriteLine($"День недели № {number} - Понедельник");
    break;
    }
    case 2:
    {
        WriteLine($"День недели № {number} - Вторник");
        break;
    }
    case 3:
    {
        WriteLine($"День недели № {number} - Среда");
        break;
    }
    case 4:
    {
        WriteLine($"День недели № {number} - Четверг");
        break;
    }
    case 5:
    {
        WriteLine($"День недели № {number} - Пятница");
        break;
    }
    case 6:
    {
        WriteLine($"День недели № {number} - Суббота");
        break;
    }
    case 7:
    {
        WriteLine($"День недели № {number} - Воскресенье");
        break;
    }
    default:
    {
        WriteLine("Нет такого дня");
        break;
    }
}
