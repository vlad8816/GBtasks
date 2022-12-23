// Задача: На заводе смена:
// Вводим количество младших токарей, которые делают х деталей
// Вводим количество старший токарей, которые делают 2х деталей
// Написать программу, на вход принимает кол-во деталей и говорит
// а) Может ли быть такое количество деталей, произведенное этой командой за смену?
// б) Если не может, то сказать, что токарь ошибся, а если может, то дать ответ сколько деталей сделал каждый


using static System.Console;
Clear();
WriteLine("Введите число деталей");
int number_of_details = Convert.ToInt32(ReadLine()!);

WriteLine("Введите количество младших токарей");
int lower_workers= Convert.ToInt32(ReadLine()!);

WriteLine("Введите количество старших токарей");
int higher_workers = Convert.ToInt32(ReadLine()!);

int lower_workers_production = 1;
int higher_workers_production = 2 * (lower_workers_production + lower_workers_production); 
int all_details = lower_workers_production * lower_workers + higher_workers_production * higher_workers;

if(number_of_details % all_details == 0 )
{
    WriteLine($"Такое количество деталей может быть, так как младшие токари сделали по {number_of_details / all_details * lower_workers_production},старшие токари сделали {number_of_details / all_details * higher_workers_production}");
}
else 
    WriteLine("Токарь ошибся, такого кол-ва быть не может");
