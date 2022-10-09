// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("ВВедите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int d = int.Parse(Console.ReadLine());

if(a*a==d)
{
    Console.WriteLine("Число " + a + " является квадратом числа " + d);
}

else if(d*d==a)
{
    Console.WriteLine("Число " + d + " является квадратом числа " + a);
}

else
{
    Console.WriteLine("не является одно квадратом другого");
}