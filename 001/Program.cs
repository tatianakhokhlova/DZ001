Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

if(a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Данное число кратно 7 и 23");
}
else
{
    Console.WriteLine("Данное число не кратно 7 и 23");
}