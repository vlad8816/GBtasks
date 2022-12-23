////Напишите программу, которая будет принимать на вход два числа и выводить,только знак '>','<' или '=' между ними
using static System.Console;
Clear();

WriteLine("Введите первое число ");
int first_number = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число ");
int second_number = Convert.ToInt32(ReadLine());
WriteLine(first_number==second_number? "=":first_number>second_number?">":"<");// если первое число равно второму числу,то выводим '=',а иначе (:) если первое число больше второго числа выводим (истина)">" (ложь)"<"