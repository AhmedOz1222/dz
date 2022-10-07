Console.Write("Введите a ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите c ");
double c = double.Parse(Console.ReadLine());
if (a>b && a>c)
{
    Console.WriteLine("max = "+ a );
}
else if (b>a && b>c)
{
    Console.WriteLine("max = "+ b );
}
else if (c>a && c>b)
{
    Console.WriteLine("max = "+ c );
}
else 
    Console.WriteLine("a = b = c");