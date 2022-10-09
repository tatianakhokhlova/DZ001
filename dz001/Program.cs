Console.WriteLine("Введите число, обозначающее день недели");
int a = int.Parse(Console.ReadLine());

if(a>6 || a==6)
{
    Console.WriteLine("Выходной день");
}

else

{
    Console.WriteLine("Не является выходным днем");
}
