﻿// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine(number + " четверть содержит координаты: x>0 y>0");
}
else if (number == 2)
{
    Console.WriteLine(number + " четверть содержит координаты: x<0 y>0");
}
else if (number == 3)
{
    Console.WriteLine(number + " четверть содержит координаты: x<0 y<0");
}
else
{
    Console.WriteLine(number + " четверть содержит координаты: x>0 y<0");
}
