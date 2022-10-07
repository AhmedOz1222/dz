Console.Write("Введите a ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b ");
double b = double.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("max = "+ a );
}
else if (a < b)
{
    Console.WriteLine("max = "+ b );
}
else 
    Console.WriteLine("a = b");