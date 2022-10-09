Console.WriteLine("введите значение x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите значение y");
int y = int.Parse(Console.ReadLine());

if(x>0 && y>0)
{
    Console.WriteLine("первая четверть");
}

else if(x<0 && y>0)
{
    Console.WriteLine("вторая четверь");
}

else if(x<0 && y<0)
{
    Console.WriteLine("третья четверть");
}
else
{
    Console.WriteLine("четвертая четверть");
}