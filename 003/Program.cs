Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
String b = a.ToString();

if(b[0]==b[4] && b[1]==b[3])
{
    Console.WriteLine("число палиндром");
}
else
{
    Console.WriteLine("число не палиндром");
}